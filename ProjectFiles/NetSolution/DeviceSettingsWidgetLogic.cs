#region Using directives
using UAManagedCore;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.Recipe;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.Alarm;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
using FTOptix.Report;
using FTOptix.DataLogger;
#endregion

public class DeviceSettingsWidgetLogic : BaseNetLogic
{
    private const string LOGGING_CATEGORY = nameof(DeviceSettingsWidgetLogic);

    public override void Start()
    {
        IUAVariable systemNodePointer = Owner.GetVariable("SystemNode");
        if (systemNodePointer == null)
        {
            Log.Error(LOGGING_CATEGORY, "SystemNode NodePointer not found.");
            return;
        }

        NodeId systemNodeId = (NodeId)systemNodePointer.Value;
        if (systemNodeId == null || systemNodeId == NodeId.Empty)
        {
            Log.Error(LOGGING_CATEGORY, "SystemNode is not defined.");
            return;
        }

        if (InformationModel.Get(systemNodeId) is not FTOptix.System.System)
            Log.Error(LOGGING_CATEGORY, "SystemNode not found.");
    }

    public override void Stop()
    {
    }
}
