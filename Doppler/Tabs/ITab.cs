using System.Windows.Forms;

namespace Doppler.Tabs
{
    /// <summary>
    /// Interface to handle each tabs
    /// </summary>
    internal interface ITab
	{
        /// <summary>
        /// Setup for each tab relatives component
        /// </summary>
        /// <param name="tabPage">all components in the tab</param>
        void AttachComponents(TabPage tabPage);
	}
}
