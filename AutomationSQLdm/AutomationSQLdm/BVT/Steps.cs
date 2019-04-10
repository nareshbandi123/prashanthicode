
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

using AutomationSQLdm.Commons;
using AutomationSQLdm.Extensions;
using AutomationSQLdm.Configuration;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using AutomationSQLdm.DataBaseOperations;


namespace AutomationSQLdm.BVT
{
    
    [TestModule("E7D37F6D-5226-40D4-9599-A4CAAFF6A2A5", ModuleType.UserCode, 1)]
    public static class Steps 
    {
    	public static BVTRepo repo = BVTRepo.Instance;
    	
    	public static void VerifySQLdmToday()
			{
				try 
				{
					
				    repo.Application.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.Application.SQLdmPaneInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.Application.SQLdmPane.TextValue == "SQLDM Today")
						Reports.ReportLog("SQLdm Today pane is Displaying", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("SQLdm Today pane is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifySQLdmToday :" + ex.Message);
				}
			}
    	
    	public static void SelectRequiredServer(string serverName)
			{
				try 
				{
					 repo.Application.AllServersInfo.WaitForItemExists(120000);
					 TreeItem serveritem = repo.Application.AllServers.GetChildItem(serverName);
					 
					if(serveritem != null)
					{
						serveritem.ClickThis();
						Reports.ReportLog("Successfully Selected Default Server : " + serverName, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Default Server is Not Available to Select", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
						
					}
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : SelectRequiredServer :" + ex.Message);
				}
			}
    	

    	public static void VerifyDashboardView()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.btnDBCPUInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.SQLdm.btnDBCPU.Text == "CPU")
						Reports.ReportLog("Dashboard View Is Displaying", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Dashboard View Is Not Displaying", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyDashboardView :" + ex.Message);
				}
			}
        public static void ClickOnSessions()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.txtSessionsInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.txtSessions.Click();
					Reports.ReportLog("Successfully Clicked On Sessions", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnSessions :" + ex.Message);
				}
			}
        
        public static void ClickOnDetails()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.radioDetailsInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.radioDetails.Click();
					Reports.ReportLog("Successfully Clicked On Details", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnDetails :" + ex.Message);
				}
			}
        public static void ClickOnLocks()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.radioLocksInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.radioLocks.Click();
					Reports.ReportLog("Successfully Clicked On Locks", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnLocks :" + ex.Message);
				}
			}
         public static void ClickOnBlocking()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.radioBlocksInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.radioBlocks.Click();
					Reports.ReportLog("Successfully Clicked On Blocking", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnBlocking :" + ex.Message);
				}
			}
        public static void VerifySummaryUnderSessions()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.txtSUMResponseTimeInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.SQLdm.txtSUMResponseTime.TextValue == "Response Time")
						Reports.ReportLog("Summary View Under Sessions Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Summary View Under Sessions Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifySummaryUnderSessions :" + ex.Message);
				}
			}
        
        public static void VerifyDetailsViewUnderSessions()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.txtDEDetailsInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.SQLdm.txtDEDetails.TextValue == "Details")
						Reports.ReportLog("Details View Under Sessions Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Details View Under Sessions Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyDetailsViewUnderSessions :" + ex.Message);
				}
			}
        
         public static void VerifyLocksUnderSessions()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.ddlLOLockStatisticsInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.SQLdm.ddlLOLockStatistics.Visible == true)
						
						Reports.ReportLog("Locks Under Sessions Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Locks Under Sessions Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyLocksUnderSessions :" + ex.Message);
				}
			}
        public static void VerifyBlockingUnderSessions()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.txtBLBlockReportsInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.SQLdm.txtBLBlockReports.TextValue == "Block Reports")
						
						Reports.ReportLog("Block Reports Under Sessions Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Block Reports Under Sessions Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyBlockingUnderSessions :" + ex.Message);
				}
			}
        
         public static void ClickOnDetailsInOverView()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.OverViewTab.rgOVDetailsInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.OverViewTab.rgOVDetails.Click();
				    Reports.ReportLog("Successfully Clicked On Details in OverView", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnDetailsInOverView :" + ex.Message);
				}
			}
         
          public static void ClickOnConfigurationInOverView()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.OverViewTab.rgOVConfigurationInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.OverViewTab.rgOVConfiguration.Click();
				    Reports.ReportLog("Successfully Clicked On Configuration in OverView", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnConfigurationInOverView :" + ex.Message);
				}
			}
          
          public static void ClickOnActiveAlertsInOverView()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.OverViewTab.rgOVActiveAlertsInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.OverViewTab.rgOVActiveAlerts.Click();
				    Reports.ReportLog("Successfully Clicked On Active Alerts in OverView", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnActiveAlertsInOverView :" + ex.Message);
				}
			}
          
          
           public static void ClickOnTimeLineInOverView()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.OverViewTab.rgOVTimeLineInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.OverViewTab.rgOVTimeLine.Click();
				    Reports.ReportLog("Successfully Clicked On TimeLine in OverView", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnTimeLineInOverView :" + ex.Message);
				}
			}
           
           public static void ClickOnQueriesTab()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tabQueriesInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tabQueries.Click();
				    Reports.ReportLog("Successfully Clicked On Queries Tab", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnQueriesTab :" + ex.Message);
				}
			}
          
            public static void ClickOnDataBasesTab()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tabDatabasesInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tabDatabases.Click();
				    Reports.ReportLog("Successfully Clicked On DataBases Tab", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnDataBasesTab :" + ex.Message);
				}
			}
           public static void ClickOnSignatureMode()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.QueriesTab.rgQUESignatureModeInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.QueriesTab.rgQUESignatureMode.Click();
				    Reports.ReportLog("Successfully Clicked On Signature Mode in Queries", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnSignatureMode :" + ex.Message);
				}
			}
           
            public static void ClickOnStatementMode()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.QueriesTab.rgQUEStatementModeInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.QueriesTab.rgQUEStatementMode.Click();
				    Reports.ReportLog("Successfully Clicked On Statement Mode in Queries", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnStatementMode :" + ex.Message);
				}
			}
           
           public static void ClickOnQueryHistory()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.QueriesTab.rgQUEQueryHistoryInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.QueriesTab.rgQUEQueryHistory.Click();
				    Reports.ReportLog("Successfully Clicked On Query History in Queries", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnQueryHistory :" + ex.Message);
				}
			}
          
           public static void ClickOnQueryWaits()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.QueriesTab.rgQUEQueryWaitsInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.QueriesTab.rgQUEQueryWaits.Click();
				    Reports.ReportLog("Successfully Clicked On Query Waits in Queries", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnQueryWaits :" + ex.Message);
				}
			}
          
            public static void ClickOnMirroringInDB()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBMirroringInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBMirroring.Click();
				    Reports.ReportLog("Successfully Clicked On Mirroring in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnMirroringInDB :" + ex.Message);
				}
			}
            
             public static void ClickOnTablesAndIndexesInDB()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBTablesAndIndexesInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBTablesAndIndexes.Click();
				    Reports.ReportLog("Successfully Clicked On TablesAndIndexes in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnTablesAndIndexesInDB :" + ex.Message);
				}
			}
             
              public static void ClickOnBackupsAndRestoresInDB()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBBackupsAndRestoresInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBBackupsAndRestores.Click();
				    Reports.ReportLog("Successfully Clicked On BackupsAndRestores in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnBackupsAndRestoresInDB :" + ex.Message);
				}
			}
             
               public static void ClickOnFilesInDB()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBFilesInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBFiles.Click();
				    Reports.ReportLog("Successfully Clicked On Files in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnFilesInDB :" + ex.Message);
				}
			}
                
			 public static void ClickOnConfigurationInDB()
			{
				try 
				{ 
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBConfigurationInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBConfiguration.Click();
				    Reports.ReportLog("Successfully Clicked On Configuration in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnConfigurationInDB :" + ex.Message);
				}
			}
			 
			  public static void ClickOnTempDBSummary()
			{
				try 
				{ 
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBTempDBSummaryInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBTempDBSummary.Click();
				    Reports.ReportLog("Successfully Clicked On TempDBSummary in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnTempDBSummary :" + ex.Message);
				}
			}
			 
			   public static void ClickOnSummaryInDB()
			{
				try 
				{ 
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBSummaryInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.DatabasesTab.rgDBSummary.Click();
				    Reports.ReportLog("Successfully Clicked On Summary in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnSummaryInDB :" + ex.Message);
				}
			}
			   
			  public static void ClickOnServicesTab()
			  {
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tabServicesInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tabServices.Click();
				    Reports.ReportLog("Successfully Clicked On Services Tab", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnServicesTab :" + ex.Message);
				}
			  } 

            public static void ClickOnSqlAgentJobsInServices()
			{
				try 
				{					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.ServicesTab.rgSERSqlAgentJobsInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.ServicesTab.rgSERSqlAgentJobs.Click();
				    Reports.ReportLog("Successfully Clicked On Sql Agent Jobs in Services", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : ClickOnSqlAgentJobsInServices :" + ex.Message);
				}
			}
			  
			   
			  public static void VerifySummaryInServices()
			  {
			  	try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSServiceSummaryInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSServiceSummaryInfo.Exists())
					{
						repo.SQLdm.tblDBSServiceSummary.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Summary In Services Is:" + repo.SQLdm.tblDBSServiceSummary.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Summary View Displayed Successfully in Services", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Summary View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifySummaryInServices :" + ex.Message);
				}
			  }
			  
			  public static void VerifySqlAgentJobsInServices()
			  {
			  try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSServiceSqlAgentJobsInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSServiceSqlAgentJobsInfo.Exists())
					{
						repo.SQLdm.tblDBSServiceSqlAgentJobs.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Sql Agent Jobs In Services Is:" + repo.SQLdm.tblDBSServiceSqlAgentJobs.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Sql Agent Jobs View Displayed Successfully in Services", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Sql Agent Jobs View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifySqlAgentJobsInServices :" + ex.Message);
				}
			  }
			  
			 public static void VerifySqlAgentJobsJobsHistoryInServices()
			  {
			  try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSServicesJobHistoryInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSServicesJobHistoryInfo.Exists())
					{
						repo.SQLdm.tblDBSServicesJobHistory.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Sql Agent Jobs Histroy In Services Is:" + repo.SQLdm.tblDBSServicesJobHistory.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Sql Agent Jobs Histroy View Displayed Successfully in Services", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Sql Agent Jobs Histroy View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifySqlAgentJobsJobsHistoryInServices :" + ex.Message);
				}
			  }
			   
			public static void VerifyDetailsInOverView()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.View.txtOVDEChartInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.SQLdm.View.txtOVDEChart.TextValue == "Chart")
						
						Reports.ReportLog("Details View Under OverView Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Details View Under OverView Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyDetailsInOverView :" + ex.Message);
				}
			}
			
			public static void VerifyConfigurationInOverView()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.View.txtOVCONDetailsInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.SQLdm.View.txtOVCONDetails.TextValue == "Details")
						
						Reports.ReportLog("Configuration Under OverView Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Configuration Under OverView Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyConfigurationInOverView :" + ex.Message);
				}
			}
			
			public static void VerifyActiveAlertsInOverView()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.View.txtOVAADetailsInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.SQLdm.View.txtOVAADetails.TextValue == "Details")
						
						Reports.ReportLog("Active Alerts Under OverView Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Active Alerts Under OverView Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyActiveAlertsInOverView :" + ex.Message);
				}
			}
			
			public static void VerifyTimeLineInOverView()
			{
				try 
				{
					
				    repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.txtOVTLDatabasesInfo.WaitForExists(new Duration(1000000));
				    
					if (repo.SQLdm.txtOVTLDatabases.TextValue == "Databases")
						
						Reports.ReportLog("TimeLine Under OverView Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("TimeLine Under OverView Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyTimeLineInOverView :" + ex.Message);
				}
			}
			
			public static void VerifySignatureModeIsDisplayed()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblQueryEventOccerrancesInfo.WaitForItemExists(1000000);
				    
					if (repo.SQLdm.tblQueryEventOccerrances.Rows.Count >= 0 )
					{
						repo.SQLdm.tblQueryEventOccerrances.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Signature Mode Is:" + repo.SQLdm.tblQueryEventOccerrances.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Signature Mode Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Signature Mode Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifySignatureModeIsDisplayed :" + ex.Message);
				}
			}
			
			public static void VerifyStatementModeIsDisplayed()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblQueryEventOccerrancesInfo.WaitForItemExists(1000000);
				    
					if (repo.SQLdm.tblQueryEventOccerrances.Rows.Count >= 0 )
					{
						repo.SQLdm.tblQueryEventOccerrances.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Statement Mode Is:" + repo.SQLdm.tblQueryEventOccerrances.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Statement Mode Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Statement Mode Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyStatementModeIsDisplayed :" + ex.Message);
				}
			}
			
			public static void VerifyQueryHistoryIsDisplayed()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblQueryEventOccerrancesInfo.WaitForItemExists(1000000);
				    
					if (repo.SQLdm.tblQueryEventOccerrances.Rows.Count >= 0 )
					{
						repo.SQLdm.tblQueryEventOccerrances.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Query History Is:" + repo.SQLdm.tblQueryEventOccerrances.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Query History Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Query History Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyQueryHistoryIsDisplayed :" + ex.Message);
				}
			}			
			
			public static void VerifyQueryWaitsIsDisplayed()
			{
				try 
				{
				    if (repo.SQLdm.btnQWQueryWaitsOverTimeInfo.Exists())
						Reports.ReportLog("Query Waits Displayed Successfully", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					else
						Reports.ReportLog("Query Waits Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyQueryHistoryIsDisplayed :" + ex.Message);
				}
			}
						
			public static void VerifySummaryInDataBases()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSSummaryInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSSummaryInfo.Exists())
					{
						repo.SQLdm.tblDBSSummary.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Summary In DataBases Is:" + repo.SQLdm.tblDBSSummary.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Summary View Displayed Successfully in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Summary View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifySummaryInDataBases :" + ex.Message);
				}
			}
			
			public static void VerifyTempDBSummaryInDataBases()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSTempDBSummaryInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSTempDBSummaryInfo.Exists())
					{
						repo.SQLdm.tblDBSTempDBSummary.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Temp DB Summary In DataBases Is:" + repo.SQLdm.tblDBSTempDBSummary.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Temp DB Summary View Displayed Successfully in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Temp DB Summary View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyTempDBSummaryInDataBases :" + ex.Message);
				}
			}
							
			public static void VerifyConfigurationInDataBases()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSConfigurationInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSConfigurationInfo.Exists())
					{
						repo.SQLdm.tblDBSConfiguration.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Configuration In DataBases Is:" + repo.SQLdm.tblDBSConfiguration.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Configuration View Displayed Successfully in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Configuration View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyConfigurationInDataBases :" + ex.Message);
				}
			}
			
			public static void VerifyFilesInDataBases()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSFilesInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSFilesInfo.Exists())
					{
						repo.SQLdm.tblDBSFiles.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Files In DataBases Is:" + repo.SQLdm.tblDBSFiles.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Files View Displayed Successfully in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Files View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyFilesInDataBases :" + ex.Message);
				}
			}
			
			public static void VerifyTablesAndIndexesInDataBases()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSTablesAndIndexesInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSTablesAndIndexesInfo.Exists())
					{
						repo.SQLdm.tblDBSTablesAndIndexes.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Tables and Indexes In DataBases Is:" + repo.SQLdm.tblDBSTablesAndIndexes.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Tables and Indexes View Displayed Successfully in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Tables and Indexes View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyTablesAndIndexesInDataBases :" + ex.Message);
				}
			}
							
			public static void VerifyBackupsAndRestoresInDataBases()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSBackupsAndRestoresInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSBackupsAndRestoresInfo.Exists())
					{
						repo.SQLdm.tblDBSBackupsAndRestores.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Backups And Restores In DataBases Is:" + repo.SQLdm.tblDBSBackupsAndRestores.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Backups And Restores View Displayed Successfully in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Backups And Restores View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyBackupsAndRestoresInDataBases :" + ex.Message);
				}
			}
			
			public static void VerifyMirroringViewInDataBases()
			{
				try 
				{
					repo.SQLdm.SelfInfo.WaitForExists(new Duration(1000000));
				    repo.SQLdm.tblDBSMirroringInfo.WaitForItemExists(1000000);
				    
				    if (repo.SQLdm.tblDBSMirroringInfo.Exists())
					{
						repo.SQLdm.tblDBSMirroring.Rows[0].Click();
						Reports.ReportLog("No Of Records Present in Mirroring View In DataBases Is:" + repo.SQLdm.tblDBSMirroring.Rows.Count, Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
						Reports.ReportLog("Mirroring View Displayed Successfully in Databases", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("Mirroring View Is Not Displaying", Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
					}
				} 
				catch (Exception ex)
				{
					throw new Exception("Failed : VerifyMirroringViewInDataBases :" + ex.Message);
				}
			}
			
			
			
			
          //--------------------------------------
         
          
    }
}
    