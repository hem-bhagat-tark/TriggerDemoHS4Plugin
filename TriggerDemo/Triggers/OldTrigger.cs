using HomeSeer.Jui.Views;
using HomeSeer.PluginSdk.Events;
using System;
using static HSPI_TriggerDemo.Static.GlobalValues;

namespace HSPI_TriggerDemo.Triggers
{
    public class OldTrigger : AbstractTriggerType
    {
        private string LabelViewId => PageId + "LabelView";
        private string InputViewId => PageId + "InputView";

        private const string LabelViewName = "Info";
        private const string InputViewName = "Enter Some Number";

        public OldTrigger(TrigActInfo trigInfo, TriggerTypeCollection.ITriggerTypeListener listener, bool logDebug = false) : base(trigInfo, listener, logDebug)
        {
        }

        public OldTrigger(int id, int eventRef, int selectedSubTriggerIndex, byte[] dataIn, TriggerTypeCollection.ITriggerTypeListener listener, bool logDebug = false)
            : base(id, eventRef, selectedSubTriggerIndex, dataIn, listener, logDebug)
        {
        }

        public OldTrigger() : base()
        {
        }

        public override string GetPrettyString()
        {
            return "Old Trigger - AbstractTriggerType";
        }

        public override bool IsFullyConfigured()
        {
            return true;
        }

        public override bool IsTriggerTrue(bool isCondition)
        {
            return isCondition && IsFullyConfigured();
        }

        public override bool ReferencesDeviceOrFeature(int devOrFeatRef)
        {
            return false;
        }

        protected override string GetName()
        {
            return "Old Trigger - AbstractTriggerType";
        }

        protected override bool OnConfigItemUpdate(AbstractView configViewChange)
        {
            return false;
        }

        protected override void OnNewTrigger()
        {
            Console.WriteLine($"Old Trigger Count {++OldTriggerCount}");

            ConfigPage = PageFactory.CreateEventTriggerPage(PageId, Name).Page;

            //var view = new LabelView(LabelViewId, LabelViewName, "This is a old trigger that implements AbstractTriggerType");
            //ConfigPage.AddView(view);

            var view = new InputView(InputViewId, InputViewName, HomeSeer.Jui.Types.EInputType.Decimal);
            ConfigPage.AddView(view);
        }
    }
}
