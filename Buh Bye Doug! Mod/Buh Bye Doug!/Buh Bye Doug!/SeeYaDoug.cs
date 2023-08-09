using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.XR;
using UnityEditor;
using UnityEditor.Experimental;

namespace Buh_Bye_Doug_
{
    public class SeeYaDoug
    {
        public void Start()
        {
            GameObject.Find("Floating Bug Holdable").SetActive(false);
        }
    }
}
