using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend4.Controllers
{
    public class Controls : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckBox(bool IsSelected)
        {
            if (Request.Method == "POST")
            {
                ViewBag.MyArray = new string[1];
                ViewBag.Field = "CheckBox";
                ViewBag.Name = "IsSelected";
                ViewBag.myArray[0] = Convert.ToString(IsSelected);
                ViewBag.Type = "Check Box";
                return View("Result");
            }
            else return View();

        }

        public IActionResult TextBox(string myTextbox)
        {

            if (Request.Method == "POST")
            {
                ViewBag.MyArray = new string[1];
                ViewBag.Field = "TextBox";
                ViewBag.Name = "Text";
                ViewBag.myArray[0] = myTextbox;
                ViewBag.Type = "Text Box";
                return View("Result");
            }
            else return View();
        }
        public IActionResult TextArea(string myTextArea)
        {
            if (Request.Method == "POST")
            {
                ViewBag.MyArray = new string[1];
                ViewBag.Field = "TextArea";
                ViewBag.Name = "Text";
                ViewBag.myArray[0] = myTextArea;
                ViewBag.Type = "Text Area";
                return View("Result");
            }
            else return View();
        }
        public IActionResult Radio(string myRadiobutton)
        {
            if (Request.Method == "POST")
            {
                ViewBag.MyArray = new string[1];
                ViewBag.Field = "Radio";
                ViewBag.Name = "Month";
                ViewBag.myArray[0] = myRadiobutton;
                ViewBag.Type = "Radio";
                return View("Result");
            }
            else return View();
        }
        public IActionResult DropDownList(string myList)
        {
            if (Request.Method == "POST")
            {
                ViewBag.MyArray = new string[1];
                ViewBag.Field = "DropDownList";
                ViewBag.Name = "Month";
                ViewBag.myArray[0] = myList;
                ViewBag.Type = "Drop-down List";
                return View("Result");
            }
            else return View();
        }
        public IActionResult ListBox(string[] myListBox)
        {
           
            if (Request.Method == "POST")
            {
                ViewBag.MyArray = new string[myListBox.Length];
                ViewBag.Field = "ListBox";
                ViewBag.Name = "Months";
                ViewBag.Type = "List Box";
                int i=0;
                foreach (string ListBox in myListBox)
                {
                    ViewBag.myArray[i] = ListBox;
                    i++;
                }
                return View("Result");

            }
            else return View();
        }
    }
}
