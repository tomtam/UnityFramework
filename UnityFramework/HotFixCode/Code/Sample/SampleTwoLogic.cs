﻿using UnityEngine;
using System.Collections;

namespace HotFixCode
{
    public class SampleTwoLogic : UILogic
    {
        SampleTwoPanel panel = null;

        void OnClick(GameObject rGo)
        {
            Debug.Log(rGo.name);
            switch (rGo.name)
            {
                case "ButtonBack":
                    TestPanelBack();
                    break;
                default:
                    break;
            }

        }

        #region Example code
        void TestPanelBack()
        {
            PanelStack.Instance.PopPanel();
        }

        #endregion

        #region Must funcation

        protected override void PlaceLastSibling()
        {
            base.PlaceLastSibling();
        }

        protected override void PlaceFirstSibling()
        {
            base.PlaceFirstSibling();
        }

        protected override void Startup(RectTransform parent)
        {
            base.Startup(parent);
            UIUtil.CreateUI(PanelName.SampleTwo, parent, OnCreated);
        }

        protected override void OnCreated(GameObject rGo)
        {
            base.OnCreated(rGo);

            panel = behaviour.GetLShapObject() as SampleTwoPanel;
            panel.logic = this;

            behaviour.AddClick(panel.buttonBack.gameObject, OnClick);

            Enable();
        }

        protected override void Enable()
        {
            base.Enable();
        }

        protected override void Disable()
        {
            base.Disable();
        }

        protected override void Free()
        {
            base.Free();
        }
        #endregion

    }
}

