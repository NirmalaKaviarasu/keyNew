﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by SpecFlow (http://www.specflow.org/).
'     SpecFlow Version:1.9.0.77
'     SpecFlow Generator Version:1.9.0.0
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
#Region "Designer generated code"
'#pragma warning disable
Imports TechTalk.SpecFlow

Namespace KeyProjectReport.KeyProjectN.FeatureFiles
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77"),  _
     System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     NUnit.Framework.TestFixtureAttribute(),  _
     NUnit.Framework.DescriptionAttribute("Delete Newly Created Property")>  _
    Partial Public Class DeleteNewlyCreatedPropertyFeature
        
        Private Shared testRunner As TechTalk.SpecFlow.ITestRunner
        
#ExternalSource("DeleteCratedProperty.feature",1)
#End ExternalSource
        
        <NUnit.Framework.TestFixtureSetUpAttribute()>  _
        Public Overridable Sub FeatureSetup()
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner
            Dim featureInfo As TechTalk.SpecFlow.FeatureInfo = New TechTalk.SpecFlow.FeatureInfo(New System.Globalization.CultureInfo("en-US"), "Delete Newly Created Property", "In order Delete New Property as ""Affortable Housing"""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"As a Property Owner"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"I want"& _ 
                    " to have Property which is already displyed under Myproperty", ProgrammingLanguage.VB, CType(Nothing,String()))
            testRunner.OnFeatureStart(featureInfo)
        End Sub
        
        <NUnit.Framework.TestFixtureTearDownAttribute()>  _
        Public Overridable Sub FeatureTearDown()
            testRunner.OnFeatureEnd
            testRunner = Nothing
        End Sub
        
        <NUnit.Framework.SetUpAttribute()>  _
        Public Overridable Sub TestInitialize()
        End Sub
        
        <NUnit.Framework.TearDownAttribute()>  _
        Public Overridable Sub ScenarioTearDown()
            testRunner.OnScenarioEnd
        End Sub
        
        Public Overridable Sub ScenarioSetup(ByVal scenarioInfo As TechTalk.SpecFlow.ScenarioInfo)
            testRunner.OnScenarioStart(scenarioInfo)
        End Sub
        
        Public Overridable Sub ScenarioCleanup()
            testRunner.CollectScenarioErrors
        End Sub
        
        <NUnit.Framework.TestAttribute(),  _
         NUnit.Framework.DescriptionAttribute("Delete Newly Created Property as ""Affortable Housing"""),  _
         NUnit.Framework.CategoryAttribute("Delete")>  _
        Public Overridable Sub DeleteNewlyCreatedPropertyAsAffortableHousing()
            Dim scenarioInfo As TechTalk.SpecFlow.ScenarioInfo = New TechTalk.SpecFlow.ScenarioInfo("Delete Newly Created Property as ""Affortable Housing""", New String() {"Delete"})
#ExternalSource("DeleteCratedProperty.feature",7)
Me.ScenarioSetup(scenarioInfo)
#End ExternalSource
#ExternalSource("DeleteCratedProperty.feature",8)
 testRunner.Given("Login using Owners Account Details", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Given ")
#End ExternalSource
#ExternalSource("DeleteCratedProperty.feature",9)
 testRunner.And("Navigate to Owners Page", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("DeleteCratedProperty.feature",10)
 testRunner.And("Select Myproperty page from Owners", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("DeleteCratedProperty.feature",11)
 testRunner.And("Choose property from myproperty page to delete", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "And ")
#End ExternalSource
#ExternalSource("DeleteCratedProperty.feature",12)
 testRunner.When("I choose Option Delete", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "When ")
#End ExternalSource
#ExternalSource("DeleteCratedProperty.feature",13)
 testRunner.Then("Property should get deleted Successfully", CType(Nothing,String), CType(Nothing,TechTalk.SpecFlow.Table), "Then ")
#End ExternalSource
            Me.ScenarioCleanup
        End Sub
    End Class
End Namespace
'#pragma warning restore
#End Region