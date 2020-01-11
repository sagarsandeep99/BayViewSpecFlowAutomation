﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFramework.ProjectLibs.Tests.TestCases.UI.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("RegisterXpo", SourceFile="ProjectLibs\\Tests\\TestCases\\UI\\FeatureFiles\\RegisterXpo.feature", SourceLine=0)]
    public partial class RegisterXpoFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RegisterXpo.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RegisterXpo", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void GoToRegisterPage(
                    string url, 
                    string fn, 
                    string ln, 
                    string jobtitle, 
                    string email, 
                    string reemail, 
                    string pwd, 
                    string repwd, 
                    string accnt, 
                    string phno, 
                    string add1, 
                    string cnt, 
                    string city, 
                    string state, 
                    string zip, 
                    string ind, 
                    string weekly, 
                    string thankyouPg, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "new"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Go To Register Page", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given(string.Format("User is at registration page {0}", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When(string.Format("User enters {0} {1} {2} {3} {4} {5} {6}", fn, ln, jobtitle, email, reemail, pwd, repwd), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
 testRunner.And(string.Format("also enters {0} {1} {2} {3} {4} {5} {6} {7} and {8}", accnt, phno, add1, city, state, zip, ind, weekly, cnt), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("user clicks on create account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then(string.Format("User is navigated to Xpo {0}", thankyouPg), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Go To Register Page, Variant 0", new string[] {
                "new",
                "source:DataResources\\XpoData.xlsx"}, SourceLine=0)]
        public virtual void GoToRegisterPage_Variant0()
        {
            this.GoToRegisterPage("http://192.168.1.16/dispatchOfficeWeb/Registration", "abc", "efg", "qa", "spectest10@abc.com", "spectest10@abc.com", "abc123", "abc123", "xyz", "1234567890", "add", "United States", "Sitka", "AK", "99801", "Furniture", "50", "Thank you for registering to be a XPO Logistics account holder", new string[] {
                        "source:DataResources\\XpoData.xlsx"});
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Go To Register Page, Variant 1", new string[] {
                "new",
                "source:DataResources\\XpoData.xlsx"}, SourceLine=0)]
        public virtual void GoToRegisterPage_Variant1()
        {
            this.GoToRegisterPage("http://192.168.1.16/dispatchOfficeWeb/Registration", "erf", "hgt", "test", "spectest11@abc.com", "spectest11@abc.com", "abc123", "abc123", "xyz", "1234567890", "add", "United States", "Sitka", "AK", "99801", "Furniture", "50", "Thank you for registering to be a XPO Logistics account holder", new string[] {
                        "source:DataResources\\XpoData.xlsx"});
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
