using System.Collections.Generic;
using System.Linq;
using GISSample.PlateauAttributeDisplay.Gml;
using GISSample.PlateauAttributeDisplay.UI.UIWindow;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

namespace GISSample.PlateauAttributeDisplay.UI
{
    /// <summary>
    /// GISサンプルにおけるUI全般を制御します。
    /// UIウィンドウの管理とクリックでの選択を管理します。
    /// </summary>
    public class GisUiController : MonoBehaviour
    {
        public MenuUi MenuUi { get; private set; }

        [SerializeField, Tooltip("操作説明")] private UIDocument userGuideUi;
        private AttributeUi attrUi;
        private TimeUi timeUi;
        private HashSet<FloodingTitle> floodingTitles;

        private SceneManager sceneManager;
    
    

        [SerializeField, Tooltip("選択中オブジェクトの色")] private Color selectedColor;
        [SerializeField, Tooltip("色分け（高さ）の色テーブル")] public Color[] heightColorTable;
        [SerializeField, Tooltip("色分け（浸水ランク）の色テーブル")] public Color[] floodingRankColorTable;
    
    
        /// <summary>
        /// 色分けタイプ
        /// </summary>
        private ColorCodeType colorCodeType;
    
        /// <summary>
        /// 浸水エリア名（色分け用）
        /// </summary>
        private FloodingTitle floodingTitle;

        public void Init(SceneManager sceneManagerArg, HashSet<FloodingTitle> floodingTitles)
        {
            sceneManager = sceneManagerArg;
            MenuUi = GetComponentInChildren<MenuUi>();
            attrUi = GetComponentInChildren<AttributeUi>();
            timeUi = FindObjectOfType<TimeUi>();

            
            userGuideUi.gameObject.SetActive(true);
            MenuUi.Init(this, sceneManagerArg, floodingTitles);
            timeUi.Init();
            attrUi.Init();
            this.floodingTitles = floodingTitles;
        
            ColorCity(colorCodeType, floodingTitle);
        
        
        }

        public void Update()
        {
            MenuUi.Update();
        }
    
        /// <summary>
        /// オブジェクトのピック
        /// マウスの位置からレイキャストしてヒットしたオブジェクトのTransformを返します。
        /// </summary>
        /// <returns>Transform</returns>
        private Transform PickObject()
        {
            var cam = Camera.main;
            if (cam == null)
            {
                Debug.LogError("main camera is not found.");
                return null;
            }
            var ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());

            // 一番手前のオブジェクトを選びます。
            float nearestDistance = float.MaxValue;
            Transform nearestTransform = null;
            // ReSharper disable once Unity.PreferNonAllocApi
            foreach (var hit in Physics.RaycastAll(ray))
            {
                var hitTrans = hit.transform;
                if (hitTrans.name.Contains("Cesium")) continue;
                if (hit.distance <= nearestDistance)
                {
                    nearestDistance = hit.distance;
                    nearestTransform = hitTrans;
                }
            }

            return nearestTransform;
        }
    
    
        /// <summary>
        /// オブジェクト選択
        /// </summary>
        /// <param name="context"></param>
        public void OnSelectObject(InputAction.CallbackContext context)
        {
            if (!context.performed || IsMousePositionInUiRect()) return;
            var trans = PickObject();
            if (trans == null)
            {
                // 何もない箇所がクリックされたら属性情報UIを閉じる
                attrUi.Close();
                return;
            }

            // 前回選択中のオブジェクトの色を戻すために色分け処理を実行
            RecolorFlooding();

            // 選択されたオブジェクトの色を変更
            var nameKey = trans.parent.parent.name;
            var cityObj = sceneManager.GetCityObject(nameKey, trans.name);
            if (cityObj == null)
            {
                // 地物でないものがクリックされたら属性情報UIを閉じる
                attrUi.Close();
                return;
            }
            attrUi.SelectCityObj(cityObj, selectedColor);

            attrUi.Open();

            var data = GetAttribute(nameKey, trans.name);
            attrUi.SetAttributes(data);
        }
    
    
        /// <summary>
        /// マウスの位置がUI上にあるかどうか
        /// </summary>
        /// <returns></returns>
        public static bool IsMousePositionInUiRect()
        {
            var pointer = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };
            var raycastResults = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointer, raycastResults);
            return raycastResults.Any(r => r.gameObject.name == "GISSamplePanelSettings");
        }
    
    
        /// <summary>
        /// 属性情報を取得
        /// </summary>
        /// <param name="gmlFileName">GMLファイル名</param>
        /// <param name="cityObjectID">CityObjectID</param>
        /// <returns>属性情報</returns>
        private SampleAttribute GetAttribute(string gmlFileName, string cityObjectID)
        {
            return sceneManager.GetAttribute(gmlFileName, cityObjectID);
        }
    
        /// <summary>
        /// 色分け処理
        /// </summary>
        public void ColorCity(ColorCodeType type, FloodingTitle floodingTitleArg)
        {
            sceneManager.ColorCity(type, floodingTitleArg);
        }
    
        /// <summary>
        /// 色分け選択変更イベントコールバック
        /// </summary>
        /// <param name="e"></param>
        public void OnColorCodeGroupValueChanged(ChangeEvent<int> e)
        {
            // valueは
            // 0: 色分けなし
            // 1: 高さ
            // 2～: 浸水ランク
            if (e.newValue < 2)
            {
                colorCodeType = (ColorCodeType)e.newValue;
                floodingTitle = null;
            }
            else
            {
                colorCodeType = ColorCodeType.FloodingRank;
                floodingTitle = floodingTitles.First(t => t.ToString() == MenuUi.colorCodeGroup.choices.ElementAt(e.newValue));
            }

            RecolorFlooding();
        }

        public void RecolorFlooding()
        {
            ColorCity(colorCodeType, floodingTitle);
        }

    

    
    }
}