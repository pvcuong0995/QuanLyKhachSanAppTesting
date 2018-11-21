using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDataProject
{
    [TestClass()]
    public class TestGetData : SqlDatabaseTestClass
    {

        public TestGetData()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getDsHoaDonTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestGetData));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getDsKhachHangTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getDsNhanVienTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getDsPhongTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_getDsDatPhongTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition checksumCondition5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition scalarValueCondition5;
            this.dbo_getDsHoaDonTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getDsKhachHangTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getDsNhanVienTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getDsPhongTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.dbo_getDsDatPhongTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_getDsHoaDonTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            scalarValueCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_getDsKhachHangTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            scalarValueCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_getDsNhanVienTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            scalarValueCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_getDsPhongTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            scalarValueCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            dbo_getDsDatPhongTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            checksumCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ChecksumCondition();
            scalarValueCondition5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // dbo_getDsHoaDonTest_TestAction
            // 
            dbo_getDsHoaDonTest_TestAction.Conditions.Add(rowCountCondition4);
            dbo_getDsHoaDonTest_TestAction.Conditions.Add(checksumCondition4);
            dbo_getDsHoaDonTest_TestAction.Conditions.Add(scalarValueCondition4);
            resources.ApplyResources(dbo_getDsHoaDonTest_TestAction, "dbo_getDsHoaDonTest_TestAction");
            // 
            // rowCountCondition4
            // 
            rowCountCondition4.Enabled = true;
            rowCountCondition4.Name = "rowCountCondition4";
            rowCountCondition4.ResultSet = 1;
            rowCountCondition4.RowCount = 1;
            // 
            // checksumCondition4
            // 
            checksumCondition4.Checksum = "1875785465";
            checksumCondition4.Enabled = true;
            checksumCondition4.Name = "checksumCondition4";
            // 
            // scalarValueCondition4
            // 
            scalarValueCondition4.ColumnNumber = 3;
            scalarValueCondition4.Enabled = true;
            scalarValueCondition4.ExpectedValue = "DP001";
            scalarValueCondition4.Name = "scalarValueCondition4";
            scalarValueCondition4.NullExpected = false;
            scalarValueCondition4.ResultSet = 1;
            scalarValueCondition4.RowNumber = 1;
            // 
            // dbo_getDsKhachHangTest_TestAction
            // 
            dbo_getDsKhachHangTest_TestAction.Conditions.Add(rowCountCondition3);
            dbo_getDsKhachHangTest_TestAction.Conditions.Add(checksumCondition3);
            dbo_getDsKhachHangTest_TestAction.Conditions.Add(scalarValueCondition3);
            resources.ApplyResources(dbo_getDsKhachHangTest_TestAction, "dbo_getDsKhachHangTest_TestAction");
            // 
            // rowCountCondition3
            // 
            rowCountCondition3.Enabled = true;
            rowCountCondition3.Name = "rowCountCondition3";
            rowCountCondition3.ResultSet = 1;
            rowCountCondition3.RowCount = 10;
            // 
            // checksumCondition3
            // 
            checksumCondition3.Checksum = "-1496969242";
            checksumCondition3.Enabled = true;
            checksumCondition3.Name = "checksumCondition3";
            // 
            // scalarValueCondition3
            // 
            scalarValueCondition3.ColumnNumber = 1;
            scalarValueCondition3.Enabled = true;
            scalarValueCondition3.ExpectedValue = "KH101";
            scalarValueCondition3.Name = "scalarValueCondition3";
            scalarValueCondition3.NullExpected = false;
            scalarValueCondition3.ResultSet = 1;
            scalarValueCondition3.RowNumber = 9;
            // 
            // dbo_getDsNhanVienTest_TestAction
            // 
            dbo_getDsNhanVienTest_TestAction.Conditions.Add(rowCountCondition2);
            dbo_getDsNhanVienTest_TestAction.Conditions.Add(checksumCondition2);
            dbo_getDsNhanVienTest_TestAction.Conditions.Add(scalarValueCondition2);
            resources.ApplyResources(dbo_getDsNhanVienTest_TestAction, "dbo_getDsNhanVienTest_TestAction");
            // 
            // rowCountCondition2
            // 
            rowCountCondition2.Enabled = true;
            rowCountCondition2.Name = "rowCountCondition2";
            rowCountCondition2.ResultSet = 1;
            rowCountCondition2.RowCount = 13;
            // 
            // checksumCondition2
            // 
            checksumCondition2.Checksum = "679578466";
            checksumCondition2.Enabled = true;
            checksumCondition2.Name = "checksumCondition2";
            // 
            // scalarValueCondition2
            // 
            scalarValueCondition2.ColumnNumber = 1;
            scalarValueCondition2.Enabled = true;
            scalarValueCondition2.ExpectedValue = "NV004";
            scalarValueCondition2.Name = "scalarValueCondition2";
            scalarValueCondition2.NullExpected = false;
            scalarValueCondition2.ResultSet = 1;
            scalarValueCondition2.RowNumber = 4;
            // 
            // dbo_getDsPhongTest_TestAction
            // 
            dbo_getDsPhongTest_TestAction.Conditions.Add(rowCountCondition1);
            dbo_getDsPhongTest_TestAction.Conditions.Add(checksumCondition1);
            dbo_getDsPhongTest_TestAction.Conditions.Add(scalarValueCondition1);
            resources.ApplyResources(dbo_getDsPhongTest_TestAction, "dbo_getDsPhongTest_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 30;
            // 
            // checksumCondition1
            // 
            checksumCondition1.Checksum = "1557271792";
            checksumCondition1.Enabled = true;
            checksumCondition1.Name = "checksumCondition1";
            // 
            // scalarValueCondition1
            // 
            scalarValueCondition1.ColumnNumber = 1;
            scalarValueCondition1.Enabled = true;
            scalarValueCondition1.ExpectedValue = "D104";
            scalarValueCondition1.Name = "scalarValueCondition1";
            scalarValueCondition1.NullExpected = false;
            scalarValueCondition1.ResultSet = 1;
            scalarValueCondition1.RowNumber = 1;
            // 
            // dbo_getDsDatPhongTest_TestAction
            // 
            dbo_getDsDatPhongTest_TestAction.Conditions.Add(rowCountCondition5);
            dbo_getDsDatPhongTest_TestAction.Conditions.Add(checksumCondition5);
            dbo_getDsDatPhongTest_TestAction.Conditions.Add(scalarValueCondition5);
            resources.ApplyResources(dbo_getDsDatPhongTest_TestAction, "dbo_getDsDatPhongTest_TestAction");
            // 
            // rowCountCondition5
            // 
            rowCountCondition5.Enabled = true;
            rowCountCondition5.Name = "rowCountCondition5";
            rowCountCondition5.ResultSet = 1;
            rowCountCondition5.RowCount = 20;
            // 
            // checksumCondition5
            // 
            checksumCondition5.Checksum = "1429950451";
            checksumCondition5.Enabled = true;
            checksumCondition5.Name = "checksumCondition5";
            // 
            // scalarValueCondition5
            // 
            scalarValueCondition5.ColumnNumber = 3;
            scalarValueCondition5.Enabled = true;
            scalarValueCondition5.ExpectedValue = "KH002";
            scalarValueCondition5.Name = "scalarValueCondition5";
            scalarValueCondition5.NullExpected = false;
            scalarValueCondition5.ResultSet = 1;
            scalarValueCondition5.RowNumber = 19;
            // 
            // dbo_getDsHoaDonTestData
            // 
            this.dbo_getDsHoaDonTestData.PosttestAction = null;
            this.dbo_getDsHoaDonTestData.PretestAction = null;
            this.dbo_getDsHoaDonTestData.TestAction = dbo_getDsHoaDonTest_TestAction;
            // 
            // dbo_getDsKhachHangTestData
            // 
            this.dbo_getDsKhachHangTestData.PosttestAction = null;
            this.dbo_getDsKhachHangTestData.PretestAction = null;
            this.dbo_getDsKhachHangTestData.TestAction = dbo_getDsKhachHangTest_TestAction;
            // 
            // dbo_getDsNhanVienTestData
            // 
            this.dbo_getDsNhanVienTestData.PosttestAction = null;
            this.dbo_getDsNhanVienTestData.PretestAction = null;
            this.dbo_getDsNhanVienTestData.TestAction = dbo_getDsNhanVienTest_TestAction;
            // 
            // dbo_getDsPhongTestData
            // 
            this.dbo_getDsPhongTestData.PosttestAction = null;
            this.dbo_getDsPhongTestData.PretestAction = null;
            this.dbo_getDsPhongTestData.TestAction = dbo_getDsPhongTest_TestAction;
            // 
            // dbo_getDsDatPhongTestData
            // 
            this.dbo_getDsDatPhongTestData.PosttestAction = null;
            this.dbo_getDsDatPhongTestData.PretestAction = null;
            this.dbo_getDsDatPhongTestData.TestAction = dbo_getDsDatPhongTest_TestAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        public void dbo_getDsHoaDonTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getDsHoaDonTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }

        [TestMethod()]
        public void dbo_getDsKhachHangTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getDsKhachHangTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }

        [TestMethod()]
        public void dbo_getDsNhanVienTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getDsNhanVienTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }

        [TestMethod()]
        public void dbo_getDsPhongTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getDsPhongTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }
        [TestMethod()]
        public void dbo_getDsDatPhongTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_getDsDatPhongTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            // Execute the test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
            SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            // Execute the post-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
            SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
        }

private SqlDatabaseTestActions dbo_getDsHoaDonTestData;
private SqlDatabaseTestActions dbo_getDsKhachHangTestData;
private SqlDatabaseTestActions dbo_getDsNhanVienTestData;
private SqlDatabaseTestActions dbo_getDsPhongTestData;
private SqlDatabaseTestActions dbo_getDsDatPhongTestData;
    }
}
