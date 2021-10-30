using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace StoryXML.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Create()
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(Server.MapPath("../Story.xml"));
            XmlNode RootNode = XmlDoc.SelectSingleNode("contacts");

            int storyNumber = RootNode.ChildNodes.Count;
            XmlNode contactNode = RootNode.AppendChild(XmlDoc.CreateNode(XmlNodeType.Element, "Story", ""));

            contactNode.AppendChild(XmlDoc.CreateNode(XmlNodeType.Element, "Id", "")).InnerText = storyNumber.ToString();
            contactNode.AppendChild(XmlDoc.CreateNode(XmlNodeType.Element, "Name", "")).InnerText = contact.name;


            XmlDoc.Save(Server.MapPath("../Story.xml"));


            return RedirectToAction("AllStory");
            
        }

        public ActionResult AllStory()
        {
            return View();
        }

    }
}