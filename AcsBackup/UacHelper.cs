/*
 * Copyright (c) Martin Kinkelin
 *
 * See the "License.txt" file in the root directory for infos
 * about permitted and prohibited uses of this code.
 */

using System;
using System.Management;
using System.Security.Principal;

namespace AcsBackup
{
	public static class UacHelper
	{
		public static bool IsInAdminRole()
		{
			// user needs to have elevated Admin privileges
			var wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
			return wp.IsInRole(WindowsBuiltInRole.Administrator);
		}

		public static bool IsRobocopyBackupModeSupported()
		{
			// user needs to be in "Backup Operators" group or have elevated Admin privileges
			var wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
			return wp.IsInRole(WindowsBuiltInRole.BackupOperator) || wp.IsInRole(WindowsBuiltInRole.Administrator);
		}

		public class HardDrive
		{
			public string Model { get; set; }
			public string InterfaceType { get; set; }
			public string Caption { get; set; }
			public string SerialNo { get; set; }
		}
		public static string GetHDD()
		{
			var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
			HardDrive hd = new HardDrive();
			foreach (ManagementObject wmi_HD in searcher.Get())
			{

				hd.Model = wmi_HD["Model"].ToString();
				hd.InterfaceType = wmi_HD["InterfaceType"].ToString();
				hd.Caption = wmi_HD["Caption"].ToString();
				hd.SerialNo = wmi_HD.GetPropertyValue("SerialNumber").ToString();
				if (hd.SerialNo.Length < 3)
					continue;
			}
			return hd.SerialNo;
		}
	}
}
