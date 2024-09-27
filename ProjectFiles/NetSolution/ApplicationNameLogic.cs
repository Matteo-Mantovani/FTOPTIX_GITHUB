#region Using directives
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.SerialPort;
using FTOptix.Recipe;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.Alarm;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
using FTOptix.Report;
#endregion

public class ApplicationNameLogic : BaseNetLogic
{
    public override void Start()
    {
        Label label = Owner as Label;
        label.Text = Project.Current.BrowseName;
    }

    public override void Stop()
    {
    }
}
