﻿using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace DemoGH
{
    public class DemoGHInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "DemoGH";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("578b2e50-19f1-488a-8c07-e734dcbe50cb");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
