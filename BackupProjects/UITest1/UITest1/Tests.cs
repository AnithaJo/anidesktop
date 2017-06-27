using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace UITest1
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                // TODO: Update this path to point to your Android app and uncomment the
                // code if the app is not included in the solution.
                //.ApkFile ("../../../Android/bin/Debug/UITestsAndroid.apk")
                .ApkFile("C:\\Users\\admin\\Desktop\\app\\com.honeywell-Signed.apk")
                
                //.DeviceSerial("52031de0c0c6a341")
                .StartApp();
        }

        [Test]
        public void NewTest()
        {
            app.Screenshot("App is open");
            app.Tap(x => x.Class("EntryEditText"));
            //app.Screenshot("Tapped on view with class: EntryEditText");
            // step 2
            app.EnterText(x => x.Class("EntryEditText"), "sandy");
            app.PressEnter();
            app.Tap(x => x.Class("EntryEditText").Index(1));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "engg");
            app.PressEnter();
            app.Tap(x => x.Class("EntryEditText").Index(2));
            app.EnterText(x => x.Class("EntryEditText").Index(2), "public");
            app.Tap(x => x.Class("EntryEditText").Index(3));
            app.EnterText(x => x.Class("EntryEditText").Index(3), "sandy@public.com");
            app.Tap(x => x.Class("EntryEditText").Index(4));
            app.EnterText(x => x.Class("EntryEditText").Index(4), "1234567890");
            app.PressEnter();
            app.Screenshot("Pressed enter key");
            // step 3
            app.Tap(x => x.Text("GET STARTED"));
            app.Screenshot("Tapped on view with class: Button with text: GET STARTED");
            // step 4
            app.Tap(x => x.Text("NEW PROJECT"));
            app.WaitForElement(x => x.Marked("SiteName"));
            app.Screenshot("Tapped on view with class: FormsTextView with text: Copy project settings from\nanother project");
            // step 5
            app.Tap(x => x.Marked("siteName"));
            app.EnterText(x => x.Marked("siteName"), "first");
            app.PressEnter();
            app.Tap(x => x.Marked("EntrySiteLoc"));
            app.EnterText(x => x.Marked("EntrySiteLoc"), "germany");
            app.PressEnter();
            app.Tap(x => x.Text("Project Type").Index(1));
            app.TouchAndHold(x => x.Text("Commercial"));
            app.Screenshot("Long press on view with class: Platform_DefaultRenderer");
            // step 6
            app.TouchAndHold(x => x.Text("Advanced Settings"));
            app.Screenshot("Entered text: D");
            // step 7
            app.Tap(x => x.Text("02"));
            app.Screenshot("Entered text: 02");

            // step 8
            for (int i = 0; i < 2; i++)
            {
                app.ScrollDown();
                if ((app.Query(x => x.Marked("Panel Languages"))).Length > 0)
                {
                    break;
                }

            }
            app.Screenshot("Scrolled for the Panel Language");
            // step 9
            app.Tap(x => x.Class("EditText").Index(2));
            app.Screenshot("Tapped on view with class: EditText");
            // step 10
            app.Tap(x => x.Id("button1"));
            app.Screenshot("Tapped on OK");
            // step 11
            for (int i = 0; i < 2; i++)
            {
                app.ScrollDown();
                if ((app.Query(x => x.Marked("No of repeaters"))).Length > 0)
                {
                    break;
                }
            }
            // step 12
            app.Tap(x => x.Text("+").Index(1));
            app.Tap(x => x.Text("+").Index(1));
            app.Tap(x => x.Text("+").Index(1));
            app.Tap(x => x.Text("+").Index(1));
            app.Tap(x => x.Text("+").Index(1));
            //app.Tap(x => x.Text("+").Index(2));
            //app.Tap(x => x.Text("+").Index(2));
            //app.Tap(x => x.Text("+").Index(2));
            //app.Tap(x => x.Text("+").Index(2));
            //app.Tap(x => x.Text("+").Index(2));
            app.Screenshot("Tapped on view with class: Button with text: +");
            // step     
            app.Back();
            app.Tap(x => x.Text("CREATE"));
            app.Screenshot("Tapped on view with class: Button with text: CREATE");





            //for (int i = 0; i < 6; i++)
            //{
            //    app.Back();
            //    if ((app.Query(x => x.Marked("Do you really want to exit?"))).Length > 0)
            //    {
            //        break;
            //    }
            //    for (i = 0; i < 2000; i++)
            //    {
            //        ;
            //    }

            //}
            //app.Screenshot("about to exit");

            //app.Tap(x => x.Id("button1"));
            //app.Screenshot("app closed");

            //BeforeEachTest();
            //app.Screenshot("reopen");







            // step 
            app.TouchAndHold(x => x.Text("first"));
            app.Screenshot("Long press on view with class: Platform_DefaultRenderer");
            // step 
            app.Tap(x => x.Text("NEW PANEL"));
            app.Screenshot("Tapped on view with class: Button with text: NEW PANEL");
            // step 
            app.Tap(x => x.Class("EntryEditText"));
            app.EnterText(x => x.Class("EntryEditText"), "dxc");
            app.PressEnter();
            app.Screenshot("dxc");
            // step 
            app.Tap(x => x.Class("EntryEditText").Index(1));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "first floor");
            app.PressEnter();
            app.Screenshot("Pressed enter key");
            // step 
            app.Tap(x => x.Text("CREATE"));
            app.Screenshot("Tapped on view with class: Button with text: CREATE");
            // step 
            app.TouchAndHold(x => x.Text("dxc"));
            app.Screenshot("pressed DXC");
            // step 
            app.TouchAndHold(x => x.Text("Devices"));
            app.Screenshot("Long press on view with class: FormsImageView");
            // step 
            app.TouchAndHold(x => x.Text("Zones"));
            app.Screenshot("Long press on view with class: FormsTextView with text: Zones");
            // step 
            app.TouchAndHold(x => x.Text("Logics"));
            app.Screenshot("Long press on view with class: LOGICS");
            // step 
            app.TouchAndHold(x => x.Text("Events"));
            app.Screenshot("Long press on view with class: FormsTextView with text: Events");
            // step 
            app.Tap(x => x.Text("All"));
            app.Screenshot("press All");
            // step 
            app.ScrollDown();
            app.Screenshot("press Fault");
            // step 
            app.Tap(x => x.Id("button1"));
            app.Screenshot("Long press on view with class: FormsImageView");
            // step 
            app.Back();
            app.Screenshot("goto prev screen");
            // step 
            app.Tap(x => x.Text("QUICK CONFIGURE"));
            app.Screenshot("Tapped on view with class: Button with text: QUICK CONFIGURE");
            // step 
            app.Tap(x => x.Text("CONTINUE"));
            app.Screenshot("Tapped on view with class: Button with text: CONTINUE");
            // step 
            app.Tap(x => x.Class("EntryEditText"));
            app.EnterText(x => x.Class("EntryEditText"), "two");
            app.PressEnter();
            app.Tap(x => x.Class("EntryEditText").Index(1));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "second floor");
            app.PressEnter();
            app.Tap(x => x.Text("04"));
            app.Screenshot("filled the page and tap on CONTINUE");
            // step 
            app.Tap(x => x.Text("CONTINUE"));
            app.Screenshot("Tapped on view with class: Button with text: CONTINUE");
            // step 
            app.Tap(x => x.Text("Loop 1"));
            app.Screenshot("Long press on view with class: LOOP 1");
            // step 
            app.Tap(x => x.Class("EntryEditText"));
            app.EnterText(x => x.Class("EntryEditText"), "20");
            app.PressEnter();
            app.Tap(x => x.Class("EntryEditText").Index(1));
            app.EnterText(x => x.Class("EntryEditText").Index(1), "0");
            app.PressEnter();
            app.Screenshot("added sensor and modules");
            // step 
            app.Tap(x => x.Text("DONE"));
            app.Screenshot("Tapped on view with class: Button with text: DONE");
            // step 
            app.Tap(x => x.Text("CONTINUE"));
            app.Screenshot("Tapped on view with class: Button with text: CONTINUE");
            // step 


            app.Tap(x => x.Text("SKIP"));
            app.Screenshot("Tapped on view with class: Button with text: SKIP");
            // step 
            app.Tap(x => x.Class("RadioButton"));
            app.Tap(x => x.Class("RadioButton").Index(2));
            app.Tap(x => x.Class("RadioButton").Index(1));
            app.Screenshot("Tapped on view with class: RadioButton");
            // step 
            app.Tap(x => x.Text("ASSIGN"));
            app.Screenshot("Tapped on view with class: Button with text: ASSIGN");
            // step 
            app.Tap(x => x.Class("RadioButton"));
            app.Tap(x => x.Class("RadioButton").Index(1));
            app.Screenshot("Long press on view with class: RadioButton");
            // step 
            app.Tap(x => x.Text("DONE"));
            app.Screenshot("Long press on view with class: Button with text: DONE");
            // step 
            app.Tap(x => x.Text("DONE"));
            app.Screenshot("Tapped on view with class: Button with text: DONE");

            app.Back();
            app.Screenshot("panels list");

            for (int i = 0; i < 6; i++)
            {
                app.Back();
                if ((app.Query(x => x.Marked("Do you really want to exit?"))).Length > 0)
                {
                    break;
                }
                else
                    continue;
            }
            app.Screenshot("about to exit");

            app.Tap(x => x.Id("button1"));
            app.Screenshot("app closed");

            BeforeEachTest();
            app.Screenshot("reopen");

            app.Flash("first");
            app.Screenshot("first flash");

            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(1))[0].Text, "first");
            app.Screenshot("assertion 1");
            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(2))[0].Text, "germany");
            app.Screenshot("assertion 2");
            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(6))[0].Text, "Commercial");
            app.Screenshot("assertion 3");

            app.TouchAndHold(x => x.Text("first"));
            app.Screenshot("Long press on view with class: Platform_DefaultRenderer");
            for (int i = 0; i < 20000; i++)
            {
                ;
            }

            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(2))[0].Text, "two");
            app.Screenshot("assertion 4");
            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(3))[0].Text, "second floor");
            app.Screenshot("assertion 5");
            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(5))[0].Text, "4");
            app.Screenshot("assertion 6");
            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(7))[0].Text, "20");
            app.Screenshot("assertion 7");

            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(12))[0].Text, "dxc");
            app.Screenshot("assertion 8");
            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(13))[0].Text, "first floor");
            app.Screenshot("assertion 9");
            Assert.AreEqual(app.Query(e => e.Class("FormsTextView").Index(15))[0].Text, "2");
            app.Screenshot("assertion 10");


            //app.ClearText(x => x.Class("EntryEditText").Text("anisainosoft@gm"));
            //app.EnterText(x => x.Class("EntryEditText").Text("anisainosoft@gm"), "anisainosoft@");
            //            app.Screenshot("App is open");
            //            app.Tap(x => x.Class("EntryEditText"));
            //            app.Screenshot("Tapped on view with class: EntryEditText");
            //            // step 2
            //            app.EnterText(x => x.Class("EntryEditText"), "sandy");
            //            app.PressEnter();
            //            app.Tap(x => x.Class("EntryEditText").Index(1));
            //            app.EnterText(x => x.Class("EntryEditText").Index(1), "engg");
            //            app.PressEnter();
            //            app.Tap(x => x.Class("EntryEditText").Index(2));
            //            app.EnterText(x => x.Class("EntryEditText").Index(2), "public");
            //            app.Tap(x => x.Class("EntryEditText").Index(3));
            //            app.EnterText(x => x.Class("EntryEditText").Index(3), "anithap.p@honeywelll.com");
            //            app.Tap(x => x.Class("EntryEditText").Index(4));
            //            app.EnterText(x => x.Class("EntryEditText").Index(4), "1234567890");
            //            app.PressEnter();
            //            app.Screenshot("Pressed enter key");
            //            // step 3
            //            app.Tap(x => x.Text("GET STARTED"));
            //            app.Screenshot("Tapped on view with class: Button with text: GET STARTED");
            //            app.Tap(x => x.Text("GET STARTED"));
            //            app.Tap(x => x.Text("NEW PROJECT"));
            //            app.Tap(x => x.Marked("siteName"));
            //            app.EnterText(x => x.Marked("siteName"), "haii");
            //            app.Tap(x => x.Marked("EntrySiteLoc"));
            //            app.EnterText(x => x.Marked("EntrySiteLoc"), "bannggaall");
            //            app.Tap(x => x.Text("Project Type"));
            //            app.EnterText(x => x.Marked("EntrySiteLoc"), "o ");
            //            app.Tap(x => x.Class("Platform_DefaultRenderer").Index(16));
            //            app.ScrollDown();
            //            app.Tap(x => x.Class("FormsImageView").Index(5));
            //            app.Tap(x => x.Class("Platform_DefaultRenderer").Index(21));
            //            app.Tap(x => x.Text("Advanced Settings"));
            //            app.EnterText(x => x.Class("EntryEditText").Text("0"), "0");
            //            app.EnterText(x => x.Class("EntryEditText").Text("0"), "6");
            //            app.ClearText(x => x.Marked("phnnumber"));
            //            app.Tap(x => x.Text("02"));
            //            app.ScrollDownTo("phnnumber");
            //            app.Tap(x => x.Marked("phnnumber"));
            //            app.EnterText(x => x.Marked("phnnumber"), "8973122347");
            //            app.ScrollDownTo("+");
            //            app.ScrollDownTo("English");
            //            app.ScrollDownTo("+");
            //            app.ScrollDownTo("+");
            //            app.DoubleTap(x => x.Text("+"));
            //            app.Tap(x => x.Text("+"));
            //            app.DoubleTap(x => x.Text("+"));
            //            app.DoubleTap(x => x.Text("+"));
            //            app.DoubleTap(x => x.Text("+"));
            //            app.DoubleTap(x => x.Text("+").Index(1));
            //            app.DoubleTap(x => x.Text("+").Index(1));
            //            app.DoubleTap(x => x.Text("+").Index(1));
            //            app.ScrollDownTo("-");
            //            app.ScrollDownTo("+");
            //            app.DoubleTap(x => x.Text("+").Index(3));
            //            app.DoubleTap(x => x.Text("+").Index(3));
            //            app.Tap(x => x.Text("+").Index(3));
            //            app.PressEnter();
            //            app.DoubleTap(x => x.Text("Alert_Alarm"));
            //            app.Tap(x => x.Id("button1"));
            //            app.Tap(x => x.Class("FormsImageView").Index(5));
            //            app.Tap(x => x.Text("CREATE"));
            //            app.Tap(x => x.Class("FormsImageView").Index(4));
            //            app.Tap(x => x.Text("QUICK CONFIGURE"));
            //            app.Tap(x => x.Text("CONTINUE"));
            //            app.Tap(x => x.Class("EntryEditText").Index(5));
            //            app.EnterText(x => x.Class("EntryEditText").Index(5), "mor");
            //            app.Tap(x => x.Class("EntryEditText").Index(6));
            //            app.EnterText(x => x.Class("EntryEditText").Index(6), "banngag");
            //            app.ScrollDown();
            //            app.ScrollDown();
            //            app.Tap(x => x.Text("CONTINUE").Index(1));
            //            app.Tap(x => x.Text("CONTINUE").Index(1));
            //            app.Tap(x => x.Id("button1"));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(10));
            //            app.Tap(x => x.Class("EntryEditText").Index(5));
            //            app.EnterText(x => x.Class("EntryEditText").Index(5), "12");
            //            app.Tap(x => x.Class("EntryEditText").Index(6));
            //            app.EnterText(x => x.Class("EntryEditText").Index(6), "01");
            //            app.Tap(x => x.Text("DONE"));
            //            app.Tap(x => x.Text("CONTINUE").Index(1));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(13));
            //            app.Tap(x => x.Text("SKIP"));
            //            app.Tap(x => x.Id("button1"));
            //            app.Tap(x => x.Class("EntryEditText").Index(7));
            //            app.EnterText(x => x.Class("EntryEditText").Index(7), "hahjj");
            //            app.PressEnter();
            //            app.Tap(x => x.Text("CONTINUE").Index(2));
            //            app.Tap(x => x.Id("button1"));
            //            app.TouchAndHold(x => x.Class("EntryEditText").Text("hahj"));
            //            app.Tap(x => x.Class("EditText").Text("Optical Smoke"));
            //            app.ClearText(x => x.Id("numberpicker_input"));
            //            app.EnterText(x => x.Id("numberpicker_input"), "Optical Smok");
            //            app.ScrollDown();
            //            app.Tap(x => x.Id("button1"));
            //            app.ClearText(x => x.Class("EditText").Text("Optical Smoke"));
            //            app.EnterText(x => x.Class("EditText").Text("Optical Smoke"), "Optical Smok");
            //            app.Tap(x => x.Text("CONTINUE").Index(2));
            //            app.Tap(x => x.Id("button1"));
            //            app.Tap(x => x.Class("FormsImageView").Index(23));
            //            app.Tap(x => x.Class("Platform_DefaultRenderer").Index(55));
            //            app.DoubleTap(x => x.Text("CONTINUE").Index(2));
            //            app.TouchAndHold(x => x.Text("hahj"));
            //            app.Tap(x => x.Text("Loop 2"));
            //            app.Tap(x => x.Text("CONTINUE").Index(2));
            //            app.Tap(x => x.Id("button1"));
            //            app.Tap(x => x.Text("Loop 1"));
            //            app.Tap(x => x.Class("FormsImageView").Index(23));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(23));
            //            app.Tap(x => x.Class("EntryEditText").Text("hahj"));
            //            app.ClearText(x => x.Class("EntryEditText").Text("hahj"));
            //            app.EnterText(x => x.Class("EntryEditText").Index(7), "hjjsjis");
            //            app.Tap(x => x.Text("CONTINUE").Index(2));
            //            app.Tap(x => x.Id("button1"));
            //            app.Tap(x => x.Text("CONTINUE").Index(2));
            //            app.Tap(x => x.Id("button1"));
            //            app.Tap(x => x.Class("Platform_DefaultRenderer").Index(18));
            //            app.Tap(x => x.Class("FormsImageView").Index(10));
            //            app.Tap(x => x.Class("FormsImageView").Index(8));
            //            app.Tap(x => x.Text("CONTINUE").Index(1));
            //            app.Tap(x => x.Text("CONTINUE").Index(1));
            //            app.Tap(x => x.Id("button1"));
            //            app.TouchAndHold(x => x.Class("Platform_DefaultRenderer").Index(38));
            //            app.Tap(x => x.Text("Input no. of devices"));
            //            app.Tap(x => x.Class("EntryEditText").Index(5));
            //            app.EnterText(x => x.Class("EntryEditText").Index(5), "12");
            //            app.Tap(x => x.Class("EntryEditText").Index(6));
            //            app.EnterText(x => x.Class("EntryEditText").Index(6), "04");
            //            app.Tap(x => x.Text("DONE"));
            //            app.Tap(x => x.Text("CONTINUE").Index(1));
            //            app.Tap(x => x.Text("SKIP"));
            //            app.Tap(x => x.Id("button1"));
            //            app.SwipeRightToLeft();
            //            app.TouchAndHold(x => x.Text("Unassigned Label"));
            //            app.TouchAndHold(x => x.Text("Unassigned Label"));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(13));
            //            app.DoubleTap(x => x.Text("SKIP"));
            //            app.Tap(x => x.Class("EntryEditText").Index(7));
            //            app.EnterText(x => x.Class("EntryEditText").Index(7), "llop ");
            //            app.Tap(x => x.Text("SKIP"));
            //            app.Tap(x => x.Id("button1"));
            //            app.ScrollDown();
            //            app.Back();
            //            app.ClearText(x => x.Class("EditText").Text("Optical Smoke"));
            //            app.ClearText(x => x.Class("EntryEditText").Text("loop "));
            //            app.ClearText(x => x.Class("EditText").Text("Optical Smoke"));
            //            app.ScrollDown();
            //            app.ClearText(x => x.Class("EditText").Text("Optical Smoke"));
            //            app.ScrollDown();
            //            app.ScrollDown();
            //app.EnterText(x => x.Class("EditText"), "O");
            //            app.EnterText(x => x.Class("EditText"), "O");
            //            app.EnterText(x => x.Class("EditText"), "O");
            //            app.ScrollUp();
            //            app.ClearText(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.EnterText(x => x.Class("EntryEditText"), "l");
            //            app.ClearText(x => x.Class("EntryEditText").Text("loop "));
            //            app.ScrollDown();
            //            app.ClearText(x => x.Class("EditText").Text("Optical Smoke"));
            //            app.EnterText(x => x.Class("EditText"), "CCCCC");
            //            app.TouchAndHold(x => x.Text("Choose Module Type").Index(2));
            //            app.TouchAndHold(x => x.Class("BoxRenderer").Index(14));
            //            app.Tap(x => x.Class("EntryEditText").Index(8));
            //            app.EnterText(x => x.Class("EntryEditText").Index(7), "6");
            //            app.DoubleTap(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.ClearText(x => x.Id("numberpicker_input"));
            //            app.EnterText(x => x.Id("numberpicker_input"), "Choose Module Typ");
            //            app.Tap(x => x.Id("button1"));
            //            app.ClearText(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.EnterText(x => x.Class("EditText").Text("Choose Module Type"), "Choose Module Typ");
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(15));
            //            app.Tap(x => x.Text("CONTINUE").Index(2));
            //            app.Tap(x => x.Id("button1"));
            //            app.ClearText(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.EnterText(x => x.Class("EditText"), "O");
            //            app.ScrollUp();
            //            app.Tap(x => x.Class("ListView").Index(1));
            //            app.TouchAndHold(x => x.Class("EntryEditText").Index(7));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(23));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(15));
            //            app.Tap(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.ClearText(x => x.Id("numberpicker_input"));
            //            app.EnterText(x => x.Id("numberpicker_input"), "Choose Module Typ");
            //            app.Tap(x => x.Id("button1"));
            //            app.ClearText(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.EnterText(x => x.Class("EditText").Text("Choose Module Type"), "Choose Module Typ");
            //            app.TouchAndHold(x => x.Class("EntryEditText").Index(7));
            //            app.TouchAndHold(x => x.Text("Unassigned Label").Index(1));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(23));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(23));
            //            app.DoubleTap(x => x.Text("CONTINUE").Index(2));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(15));
            //            app.TouchAndHold(x => x.Class("FormsImageView").Index(15));
            //            app.Tap(x => x.Class("FormsImageView").Index(23));
            //            app.TouchAndHold(x => x.Text("Choose Module Type"));
            //            app.Tap(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.ClearText(x => x.Id("numberpicker_input"));
            //            app.EnterText(x => x.Id("numberpicker_input"), "Choose Module Typ");
            //            app.Tap(x => x.Id("button1"));
            //            app.ClearText(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.EnterText(x => x.Class("EditText").Text("Choose Module Type"), "Choose Module Typ");
            //            app.ClearText(x => x.Class("EditText").Text("Sounders Unit"));
            //            app.EnterText(x => x.Class("EditText"), "S");
            //            app.ClearText(x => x.Class("EditText").Text("Optical Smoke"));
            //            app.ScrollDown();
            //            app.Tap(x => x.Text("CONTINUE").Index(2));
            //            app.Tap(x => x.Id("button1"));
            //            app.TouchAndHold(x => x.Text("Choose Module Type"));
            //            app.TouchAndHold(x => x.Text("Choose Module Type"));
            //            app.ScrollDownTo("Choose Module Type");
            //            app.Tap(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.ClearText(x => x.Id("numberpicker_input"));
            //            app.EnterText(x => x.Id("numberpicker_input"), "Sounders Uni");
            //            app.Tap(x => x.Id("button1"));
            //            app.ClearText(x => x.Class("EditText").Text("Choose Module Type"));
            //            app.EnterText(x => x.Class("EditText").Text("Choose Module Type"), "Choose Module Typ");
            //            app.Tap(x => x.Text("CONTINUE").Index(2));
            //            app.EnterText(x => x.Class("EditText"), "L");
            //            app.Tap(x => x.Class("RadioButton"));
            //            app.Tap(x => x.Text("ASSIGN"));
            //            app.TouchAndHold(x => x.Text("Zone 1"));
            //            app.Tap(x => x.Class("RadioButton").Index(6));
            //            app.Tap(x => x.Text("DONE"));
            //            app.Tap(x => x.Text("DONE"));
            //            app.Tap(x => x.Class("FormsImageView").Index(13));
            //            app.Tap(x => x.Class("FormsImageView").Index(14));
            //            app.Tap(x => x.Class("FormsImageView").Index(15));
            //            app.Tap(x => x.Class("Platform_DefaultRenderer").Index(4));                                       
            //            app.Tap(x => x.Class("FormsImageView").Index(7));
            //            app.Tap(x => x.Class("FormsImageView").Index(4));
            //            app.Back();
            //            app.Tap(x => x.Id("button1"));
            //            app.Back();
            //            app.Back();
            //            app.Back();
            //            app.Tap(x => x.Id("button1"));
        }

        //[Test]
        //   public void appstart()
        //{
        //    app.Repl();
        //}
    }
}

