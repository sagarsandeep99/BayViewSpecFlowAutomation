﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFramework.FeatureFileAPIPath
{
    public class FeatureFileAPIBasePath
    {
        public string GetFeatureFileAPIPath(string featureName)
        {
            //    string ProjFolderPath = System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString();
            //works in visual studio
             string pathForFeature = "..\\..\\SpecFramework\\SpecFramework\\ProjectLibs\\Tests\\TestCases\\API\\FeatureFiles";
            //works in teamcity and console
            //   string pathForFeature = "..\\..\\FeatureFiles";
            string filename = featureName + ".feature";
           // string[] filePaths = Directory.GetFiles(ProjFolderPath + pathForFeature, filename, SearchOption.AllDirectories);
            string[] filePaths = Directory.GetFiles(pathForFeature, filename, SearchOption.AllDirectories);
            string featurePath = filePaths.First();
            Console.WriteLine("featurepath: " + featurePath);
            return featurePath;
        }
    }
}
