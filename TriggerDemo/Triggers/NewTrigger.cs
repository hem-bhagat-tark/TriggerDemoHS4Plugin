using HomeSeer.Jui.Views;
using HomeSeer.PluginSdk.Events;
using System;
using System.Collections.Generic;
using static HSPI_TriggerDemo.Static.GlobalValues;

namespace HSPI_TriggerDemo.Triggers
{
    public class NewTrigger : AbstractTriggerType2
    {
        private string LabelViewId => PageId + "LabelView";
        private string InputViewId => PageId + "InputView";

        private const string LabelViewName = "Info";
        private const string InputViewName = "Enter Some Number";

        public NewTrigger(TrigActInfo trigInfo, TriggerTypeCollection.ITriggerTypeListener listener, bool logDebug = false) : base(trigInfo, listener, logDebug)
        {
        }

        public NewTrigger(int id, int eventRef, int selectedSubTriggerIndex, byte[] dataIn, TriggerTypeCollection.ITriggerTypeListener listener, bool logDebug = false)
            : base(id, eventRef, selectedSubTriggerIndex, dataIn, listener, logDebug)
        {
        }

        public NewTrigger() : base()
        {
        }

        public override string GetPrettyString()
        {
            return "New Trigger - AbstractTriggerType2";
        }

        public override bool IsFullyConfigured()
        {
            return true;
        }

        public override bool IsTriggerTrue(bool isCondition)
        {
            return isCondition;
        }

        public override bool ReferencesDeviceOrFeature(int devOrFeatRef)
        {
            return false;
        }

        protected override string GetName()
        {
            return "New Trigger - AbstractTriggerType2";
        }

        protected override bool OnConfigItemUpdate(AbstractView configViewChange)
        {
            return true;
        }

        protected override void OnInstantiateTrigger(Dictionary<string, string> viewIdValuePairs)
        {
            Console.WriteLine($"New Trigger Count {++NewTriggerCount}");

            ConfigPage = PageFactory.CreateEventTriggerPage(PageId, Name).Page;

            //var view = new LabelView(LabelViewId, LabelViewName, "This is a new trigger that implements AbstractTriggerType2");
            //ConfigPage.AddView(view);

            viewIdValuePairs.TryGetValue(InputViewId, out var inputValue);

            var view = new InputView(InputViewId, InputViewName, inputValue, HomeSeer.Jui.Types.EInputType.Decimal);
            ConfigPage.AddView(view);
        }
    }
}
