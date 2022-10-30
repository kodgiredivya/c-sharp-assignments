using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace DynamicallyLoadAssembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Input parameters to be passed
            object[] Parameter =  new object[1];
            Parameter[0]= textBox1.Text;

            //Call the method
            // Parameters Assembly Name, Class Name, Method Name, Parmateres as Array
            object obj = Process("BusinessLogic", "BankAccount", "GetBalance", Parameter);
            label2.Text = "Balance in your account is:" + Convert.ToString(obj);

        }

/// <summary>
/// Call the asssembly dynamically and execute a method
/// 
/// </summary>
/// <param name="AssemblyName">Name of the Assembly to be loaded</param>
/// <param name="className">Name of the class to be intantiated </param>
/// <param name="methodName">Name of the method to be called</param>
/// <param name="parameterForTheMethod">Parameters should be passed as object array</param>
/// <returns></returns>
        public static object Process(string AssemblyName, string className, string methodName, object[] parameterForTheMethod)
        {
            object returnObject = null;
            MethodInfo mi = null;
            ConstructorInfo ci = null;
            object responder = null;
            Type type = null;
            System.Type[] objectTypes;
            int count = 0;

            try
            {
                //Load the information and get it types
                type = System.Reflection.Assembly.LoadFrom(AssemblyName + ".dll").GetType(AssemblyName +"." + className);                                       
                //Get the Passed parameter types to find the method type
                objectTypes = new System.Type[parameterForTheMethod.GetUpperBound(0) + 1];
                foreach (object objectParameter in parameterForTheMethod)
                {
                    if (objectParameter != null)
                        objectTypes[count] = objectParameter.GetType();
                    count++;
                }
                //Get the refernce of the method
                mi = type.GetMethod(methodName, objectTypes);
                ci = type.GetConstructor(Type.EmptyTypes);
                responder = ci.Invoke(null);
                //Invoke the method
                returnObject = mi.Invoke(responder, parameterForTheMethod);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mi = null;
                ci = null;
                responder = null;
                type = null;
                objectTypes = null;
            }
            return returnObject;
        }
    }
}