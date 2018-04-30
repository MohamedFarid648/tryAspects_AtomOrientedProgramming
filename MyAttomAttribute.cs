using FluentValidation;
using PostSharp.Aspects;
using PostSharp.Aspects.Advices;
using PostSharp.Aspects.Configuration;
using PostSharp.Aspects.Serialization;
using PostSharp.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AspectOrientedProgramming_P1
{

    //Do these Codes for every event handler
    [PSerializable]
    public class MyAttomAttribute : MethodInterceptionAspect// : InstanceLevelAspect,INotifyDataErrorInfo //NetworkInterface
    {

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            MessageBoxResult dialogResult = MessageBox.Show("Are you Sure you want to Invoke this method?", "Method Invoking", MessageBoxButton.OKCancel);
         if(dialogResult==MessageBoxResult.OK)
            {
                MessageBox.Show("Ok Thank you ");

                base.OnInvoke(args);
            }
            else
            {
                MessageBox.Show("Ok Never Mind");
            }
               
        }


        public MyAttomAttribute()
        {
        }

    }


  
    public class MyUser
    {
        public string x { get; set; }
        public string y { get; set; }

        [MyAttomAttribute]
        public void getUser()
        {

            MessageBox.Show("User");

        }
    }

    public class MyValidator
    {

    }

}
