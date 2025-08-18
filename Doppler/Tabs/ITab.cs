using System;

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
		/// <param name="application">all components in the application</param>
		void AttachComponents(DopplerForm application);

		/// <summary>
		/// Launch process to convert videos, or truncate it for example
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Launch(object sender, EventArgs e);
	}
}
