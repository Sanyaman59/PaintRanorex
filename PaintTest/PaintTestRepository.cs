﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace PaintTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the PaintTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("d0bb2f35-8f85-4386-a4f8-aff17ade2c01")]
    public partial class PaintTestRepository : RepoGenBaseFolder
    {
        static PaintTestRepository instance = new PaintTestRepository();
        PaintTestRepositoryFolders.UntitledPaintAppFolder _untitledpaint;
        PaintTestRepositoryFolders.MspaintAppFolder _mspaint;
        PaintTestRepositoryFolders.ExplorerAppFolder _explorer;
        PaintTestRepositoryFolders.PaintAppFolder _paint;
        PaintTestRepositoryFolders.SaveAsAppFolder _saveas;
        PaintTestRepositoryFolders.ConfirmSaveAsAppFolder _confirmsaveas;
        PaintTestRepositoryFolders.EditColoursAppFolder _editcolours;

        /// <summary>
        /// Gets the singleton class instance representing the PaintTestRepository element repository.
        /// </summary>
        [RepositoryFolder("d0bb2f35-8f85-4386-a4f8-aff17ade2c01")]
        public static PaintTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public PaintTestRepository() 
            : base("PaintTestRepository", "/", null, 0, false, "d0bb2f35-8f85-4386-a4f8-aff17ade2c01", ".\\RepositoryImages\\PaintTestRepositoryd0bb2f35.rximgres")
        {
            _untitledpaint = new PaintTestRepositoryFolders.UntitledPaintAppFolder(this);
            _mspaint = new PaintTestRepositoryFolders.MspaintAppFolder(this);
            _explorer = new PaintTestRepositoryFolders.ExplorerAppFolder(this);
            _paint = new PaintTestRepositoryFolders.PaintAppFolder(this);
            _saveas = new PaintTestRepositoryFolders.SaveAsAppFolder(this);
            _confirmsaveas = new PaintTestRepositoryFolders.ConfirmSaveAsAppFolder(this);
            _editcolours = new PaintTestRepositoryFolders.EditColoursAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("d0bb2f35-8f85-4386-a4f8-aff17ade2c01")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The UntitledPaint folder.
        /// </summary>
        [RepositoryFolder("1355faec-ba2d-4911-a0e4-22465f2bb763")]
        public virtual PaintTestRepositoryFolders.UntitledPaintAppFolder UntitledPaint
        {
            get { return _untitledpaint; }
        }

        /// <summary>
        /// The Mspaint folder.
        /// </summary>
        [RepositoryFolder("53d6dc53-d2f4-43f5-a203-ea404c1270d6")]
        public virtual PaintTestRepositoryFolders.MspaintAppFolder Mspaint
        {
            get { return _mspaint; }
        }

        /// <summary>
        /// The Explorer folder.
        /// </summary>
        [RepositoryFolder("3362c981-6f33-4ce8-8d36-c99b8ece7c28")]
        public virtual PaintTestRepositoryFolders.ExplorerAppFolder Explorer
        {
            get { return _explorer; }
        }

        /// <summary>
        /// The Paint folder.
        /// </summary>
        [RepositoryFolder("90842c2a-b00f-4651-a013-f348ffe67df4")]
        public virtual PaintTestRepositoryFolders.PaintAppFolder Paint
        {
            get { return _paint; }
        }

        /// <summary>
        /// The SaveAs folder.
        /// </summary>
        [RepositoryFolder("73aa364c-c2be-48b7-9f8c-dc7b5ca4fce9")]
        public virtual PaintTestRepositoryFolders.SaveAsAppFolder SaveAs
        {
            get { return _saveas; }
        }

        /// <summary>
        /// The ConfirmSaveAs folder.
        /// </summary>
        [RepositoryFolder("09fe4d9c-c61d-4430-b3fc-6f30e375d12f")]
        public virtual PaintTestRepositoryFolders.ConfirmSaveAsAppFolder ConfirmSaveAs
        {
            get { return _confirmsaveas; }
        }

        /// <summary>
        /// The EditColours folder.
        /// </summary>
        [RepositoryFolder("8703978d-4818-40ed-b46d-9dc772776d7e")]
        public virtual PaintTestRepositoryFolders.EditColoursAppFolder EditColours
        {
            get { return _editcolours; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class PaintTestRepositoryFolders
    {
        /// <summary>
        /// The UntitledPaintAppFolder folder.
        /// </summary>
        [RepositoryFolder("1355faec-ba2d-4911-a0e4-22465f2bb763")]
        public partial class UntitledPaintAppFolder : RepoGenBaseFolder
        {
            PaintTestRepositoryFolders.HomeFolder _home;
            RepoItemInfo _canvasInfo;

            /// <summary>
            /// Creates a new UntitledPaint  folder.
            /// </summary>
            public UntitledPaintAppFolder(RepoGenBaseFolder parentFolder) :
                    base("UntitledPaint", "/form[@title='Untitled - Paint']", parentFolder, 30000, null, true, "1355faec-ba2d-4911-a0e4-22465f2bb763", "")
            {
                _home = new PaintTestRepositoryFolders.HomeFolder(this);
                _canvasInfo = new RepoItemInfo(this, "Canvas", "?/element[@processname='mspaint']", "?/?/element[@class='Afx:810000:8']", 30000, null, "85e4c37b-0e92-4de7-b97d-53c536eb986d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1355faec-ba2d-4911-a0e4-22465f2bb763")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1355faec-ba2d-4911-a0e4-22465f2bb763")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Canvas item.
            /// </summary>
            [RepositoryItem("85e4c37b-0e92-4de7-b97d-53c536eb986d")]
            public virtual Ranorex.Unknown Canvas
            {
                get
                {
                    return _canvasInfo.CreateAdapter<Ranorex.Unknown>(true);
                }
            }

            /// <summary>
            /// The Canvas item info.
            /// </summary>
            [RepositoryItemInfo("85e4c37b-0e92-4de7-b97d-53c536eb986d")]
            public virtual RepoItemInfo CanvasInfo
            {
                get
                {
                    return _canvasInfo;
                }
            }

            /// <summary>
            /// The Home folder.
            /// </summary>
            [RepositoryFolder("f7727e5f-2d37-4b5b-902e-7e99e661ff6e")]
            public virtual PaintTestRepositoryFolders.HomeFolder Home
            {
                get { return _home; }
            }
        }

        /// <summary>
        /// The HomeFolder folder.
        /// </summary>
        [RepositoryFolder("f7727e5f-2d37-4b5b-902e-7e99e661ff6e")]
        public partial class HomeFolder : RepoGenBaseFolder
        {
            RepoItemInfo _sizeInfo;
            RepoItemInfo _lineInfo;
            RepoItemInfo _ovalInfo;
            RepoItemInfo _triangleInfo;
            RepoItemInfo _curveInfo;
            RepoItemInfo _diamondInfo;
            RepoItemInfo _fillwithcolourInfo;
            RepoItemInfo _althyInfo;
            RepoItemInfo _colour1Info;
            RepoItemInfo _althy1Info;

            /// <summary>
            /// Creates a new Home  folder.
            /// </summary>
            public HomeFolder(RepoGenBaseFolder parentFolder) :
                    base("Home", "element[3]//container[@accessiblename='Lower Ribbon']/?/?/container[@accessiblename='Home']", parentFolder, 30000, null, false, "f7727e5f-2d37-4b5b-902e-7e99e661ff6e", "")
            {
                _sizeInfo = new RepoItemInfo(this, "Size", "toolbar[@accessiblekeyboardshortcut='Alt, H, Z 6']/button[@accessiblename='Size']", "", 30000, null, "4c02c406-a01d-48f5-b929-3603a8e89a9f");
                _lineInfo = new RepoItemInfo(this, "Line", "toolbar[@accessiblename='Shapes']/container[@accessiblename='Shapes']/list[@accessiblename='Shapes']/?/?/listitem[@accessiblename='Line']", "", 30000, null, "c70919e0-9b7e-4c01-b185-d32c877ca6b4");
                _ovalInfo = new RepoItemInfo(this, "Oval", "toolbar[@accessiblename='Shapes']/container[@accessiblename='Shapes']/list[@accessiblename='Shapes']/?/?/listitem[@accessiblename='Oval']", "", 30000, null, "05a5854e-4ad1-49f8-8fb2-b8cd1a8e61ce");
                _triangleInfo = new RepoItemInfo(this, "Triangle", "toolbar[@accessiblename='Shapes']/container[@accessiblename='Shapes']/list[@accessiblename='Shapes']/?/?/listitem[@accessiblename='Triangle']", "", 30000, null, "98d57d31-c5e6-4ff9-b988-4e5c95562c7d");
                _curveInfo = new RepoItemInfo(this, "Curve", "toolbar[@accessiblename='Shapes']/container[@accessiblename='Shapes']/list[@accessiblename='Shapes']/?/?/listitem[@accessiblename='Curve']", "", 30000, null, "0f912a03-7846-4664-b12c-f0ce99e2f1ef");
                _diamondInfo = new RepoItemInfo(this, "Diamond", "toolbar[@accessiblename='Shapes']/container[@accessiblename='Shapes']/list[@accessiblename='Shapes']/?/?/listitem[@accessiblename='Diamond']", "", 30000, null, "ff0b1cb8-acdb-4711-acd4-6c3ad2735c5c");
                _fillwithcolourInfo = new RepoItemInfo(this, "FillWithColour", "toolbar[@accessiblename='Tools']/button[@accessiblename='Fill with colour']", "", 30000, null, "9d55c6a5-dfe3-40b1-8bab-0496a55cb234");
                _althyInfo = new RepoItemInfo(this, "AltHY", "toolbar[@accessiblename='Colours']/button[@accessiblename='Edit colours']", "", 30000, null, "18e304c9-a27d-4ffa-8ce5-057d765d0093");
                _colour1Info = new RepoItemInfo(this, "Colour1", "toolbar[@accessiblename='Colours']/button[@accessiblename='Colour 1']", "", 30000, null, "fabf2e07-b3fa-4db9-a364-1c80189c08c2");
                _althy1Info = new RepoItemInfo(this, "AltHY1", "toolbar[@accessiblename='Colours']/container[@accessiblename='']", "", 30000, null, "0725a458-b97b-49df-b9aa-a2614e7636c8");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f7727e5f-2d37-4b5b-902e-7e99e661ff6e")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("f7727e5f-2d37-4b5b-902e-7e99e661ff6e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Size item.
            /// </summary>
            [RepositoryItem("4c02c406-a01d-48f5-b929-3603a8e89a9f")]
            public virtual Ranorex.Button Size
            {
                get
                {
                    return _sizeInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Size item info.
            /// </summary>
            [RepositoryItemInfo("4c02c406-a01d-48f5-b929-3603a8e89a9f")]
            public virtual RepoItemInfo SizeInfo
            {
                get
                {
                    return _sizeInfo;
                }
            }

            /// <summary>
            /// The Line item.
            /// </summary>
            [RepositoryItem("c70919e0-9b7e-4c01-b185-d32c877ca6b4")]
            public virtual Ranorex.ListItem Line
            {
                get
                {
                    return _lineInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Line item info.
            /// </summary>
            [RepositoryItemInfo("c70919e0-9b7e-4c01-b185-d32c877ca6b4")]
            public virtual RepoItemInfo LineInfo
            {
                get
                {
                    return _lineInfo;
                }
            }

            /// <summary>
            /// The Oval item.
            /// </summary>
            [RepositoryItem("05a5854e-4ad1-49f8-8fb2-b8cd1a8e61ce")]
            public virtual Ranorex.ListItem Oval
            {
                get
                {
                    return _ovalInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Oval item info.
            /// </summary>
            [RepositoryItemInfo("05a5854e-4ad1-49f8-8fb2-b8cd1a8e61ce")]
            public virtual RepoItemInfo OvalInfo
            {
                get
                {
                    return _ovalInfo;
                }
            }

            /// <summary>
            /// The Triangle item.
            /// </summary>
            [RepositoryItem("98d57d31-c5e6-4ff9-b988-4e5c95562c7d")]
            public virtual Ranorex.ListItem Triangle
            {
                get
                {
                    return _triangleInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Triangle item info.
            /// </summary>
            [RepositoryItemInfo("98d57d31-c5e6-4ff9-b988-4e5c95562c7d")]
            public virtual RepoItemInfo TriangleInfo
            {
                get
                {
                    return _triangleInfo;
                }
            }

            /// <summary>
            /// The Curve item.
            /// </summary>
            [RepositoryItem("0f912a03-7846-4664-b12c-f0ce99e2f1ef")]
            public virtual Ranorex.ListItem Curve
            {
                get
                {
                    return _curveInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Curve item info.
            /// </summary>
            [RepositoryItemInfo("0f912a03-7846-4664-b12c-f0ce99e2f1ef")]
            public virtual RepoItemInfo CurveInfo
            {
                get
                {
                    return _curveInfo;
                }
            }

            /// <summary>
            /// The Diamond item.
            /// </summary>
            [RepositoryItem("ff0b1cb8-acdb-4711-acd4-6c3ad2735c5c")]
            public virtual Ranorex.ListItem Diamond
            {
                get
                {
                    return _diamondInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The Diamond item info.
            /// </summary>
            [RepositoryItemInfo("ff0b1cb8-acdb-4711-acd4-6c3ad2735c5c")]
            public virtual RepoItemInfo DiamondInfo
            {
                get
                {
                    return _diamondInfo;
                }
            }

            /// <summary>
            /// The FillWithColour item.
            /// </summary>
            [RepositoryItem("9d55c6a5-dfe3-40b1-8bab-0496a55cb234")]
            public virtual Ranorex.Button FillWithColour
            {
                get
                {
                    return _fillwithcolourInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The FillWithColour item info.
            /// </summary>
            [RepositoryItemInfo("9d55c6a5-dfe3-40b1-8bab-0496a55cb234")]
            public virtual RepoItemInfo FillWithColourInfo
            {
                get
                {
                    return _fillwithcolourInfo;
                }
            }

            /// <summary>
            /// The AltHY item.
            /// </summary>
            [RepositoryItem("18e304c9-a27d-4ffa-8ce5-057d765d0093")]
            public virtual Ranorex.Button AltHY
            {
                get
                {
                    return _althyInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The AltHY item info.
            /// </summary>
            [RepositoryItemInfo("18e304c9-a27d-4ffa-8ce5-057d765d0093")]
            public virtual RepoItemInfo AltHYInfo
            {
                get
                {
                    return _althyInfo;
                }
            }

            /// <summary>
            /// The Colour1 item.
            /// </summary>
            [RepositoryItem("fabf2e07-b3fa-4db9-a364-1c80189c08c2")]
            public virtual Ranorex.Button Colour1
            {
                get
                {
                    return _colour1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Colour1 item info.
            /// </summary>
            [RepositoryItemInfo("fabf2e07-b3fa-4db9-a364-1c80189c08c2")]
            public virtual RepoItemInfo Colour1Info
            {
                get
                {
                    return _colour1Info;
                }
            }

            /// <summary>
            /// The AltHY1 item.
            /// </summary>
            [RepositoryItem("0725a458-b97b-49df-b9aa-a2614e7636c8")]
            public virtual Ranorex.Container AltHY1
            {
                get
                {
                    return _althy1Info.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The AltHY1 item info.
            /// </summary>
            [RepositoryItemInfo("0725a458-b97b-49df-b9aa-a2614e7636c8")]
            public virtual RepoItemInfo AltHY1Info
            {
                get
                {
                    return _althy1Info;
                }
            }
        }

        /// <summary>
        /// The MspaintAppFolder folder.
        /// </summary>
        [RepositoryFolder("53d6dc53-d2f4-43f5-a203-ea404c1270d6")]
        public partial class MspaintAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _listitem3pxInfo;

            /// <summary>
            /// Creates a new Mspaint  folder.
            /// </summary>
            public MspaintAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Mspaint", "/form[@title='']", parentFolder, 30000, null, true, "53d6dc53-d2f4-43f5-a203-ea404c1270d6", "")
            {
                _listitem3pxInfo = new RepoItemInfo(this, "ListItem3px", "?/?/list[@accessiblename='Size']/container[@accessiblename='']/?/?/listitem[@accessiblename='3px']", ".//listitem[@accessiblename='3px']", 30000, null, "926566c8-7710-4a64-94f4-365530c694d4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("53d6dc53-d2f4-43f5-a203-ea404c1270d6")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("53d6dc53-d2f4-43f5-a203-ea404c1270d6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ListItem3px item.
            /// </summary>
            [RepositoryItem("926566c8-7710-4a64-94f4-365530c694d4")]
            public virtual Ranorex.ListItem ListItem3px
            {
                get
                {
                    return _listitem3pxInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The ListItem3px item info.
            /// </summary>
            [RepositoryItemInfo("926566c8-7710-4a64-94f4-365530c694d4")]
            public virtual RepoItemInfo ListItem3pxInfo
            {
                get
                {
                    return _listitem3pxInfo;
                }
            }
        }

        /// <summary>
        /// The ExplorerAppFolder folder.
        /// </summary>
        [RepositoryFolder("3362c981-6f33-4ce8-8d36-c99b8ece7c28")]
        public partial class ExplorerAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _paint1runningwindowInfo;

            /// <summary>
            /// Creates a new Explorer  folder.
            /// </summary>
            public ExplorerAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Explorer", "/menubar[@processname='explorer']", parentFolder, 30000, null, true, "3362c981-6f33-4ce8-8d36-c99b8ece7c28", "")
            {
                _paint1runningwindowInfo = new RepoItemInfo(this, "Paint1RunningWindow", "container[@controlid='40965']//toolbar[@accessiblename='Running applications']/button[21]", ".//toolbar[@accessiblename='Running applications']/button[21]", 30000, null, "b731a84c-cf89-4977-8a77-f78c077deb71");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3362c981-6f33-4ce8-8d36-c99b8ece7c28")]
            public virtual Ranorex.MenuBar Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.MenuBar>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3362c981-6f33-4ce8-8d36-c99b8ece7c28")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Paint1RunningWindow item.
            /// </summary>
            [RepositoryItem("b731a84c-cf89-4977-8a77-f78c077deb71")]
            public virtual Ranorex.Button Paint1RunningWindow
            {
                get
                {
                    return _paint1runningwindowInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Paint1RunningWindow item info.
            /// </summary>
            [RepositoryItemInfo("b731a84c-cf89-4977-8a77-f78c077deb71")]
            public virtual RepoItemInfo Paint1RunningWindowInfo
            {
                get
                {
                    return _paint1runningwindowInfo;
                }
            }
        }

        /// <summary>
        /// The PaintAppFolder folder.
        /// </summary>
        [RepositoryFolder("90842c2a-b00f-4651-a013-f348ffe67df4")]
        public partial class PaintAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonsaveInfo;

            /// <summary>
            /// Creates a new Paint  folder.
            /// </summary>
            public PaintAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Paint", "/form[@title='Paint']", parentFolder, 30000, null, true, "90842c2a-b00f-4651-a013-f348ffe67df4", "")
            {
                _buttonsaveInfo = new RepoItemInfo(this, "ButtonSave", "?/?/element[@instance='0']/button[@text='&Save']", ".//button[@text='&Save']", 30000, null, "020eb5f0-65b5-4bc9-b7f7-ba1c7d0be15e");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("90842c2a-b00f-4651-a013-f348ffe67df4")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("90842c2a-b00f-4651-a013-f348ffe67df4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonSave item.
            /// </summary>
            [RepositoryItem("020eb5f0-65b5-4bc9-b7f7-ba1c7d0be15e")]
            public virtual Ranorex.Button ButtonSave
            {
                get
                {
                    return _buttonsaveInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonSave item info.
            /// </summary>
            [RepositoryItemInfo("020eb5f0-65b5-4bc9-b7f7-ba1c7d0be15e")]
            public virtual RepoItemInfo ButtonSaveInfo
            {
                get
                {
                    return _buttonsaveInfo;
                }
            }
        }

        /// <summary>
        /// The SaveAsAppFolder folder.
        /// </summary>
        [RepositoryFolder("73aa364c-c2be-48b7-9f8c-dc7b5ca4fce9")]
        public partial class SaveAsAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonsaveInfo;

            /// <summary>
            /// Creates a new SaveAs  folder.
            /// </summary>
            public SaveAsAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SaveAs", "/form[@title='Save As']", parentFolder, 30000, null, true, "73aa364c-c2be-48b7-9f8c-dc7b5ca4fce9", "")
            {
                _buttonsaveInfo = new RepoItemInfo(this, "ButtonSave", "button[@text='&Save']", "button[@text='&Save']", 30000, null, "8041acb4-e08b-44f6-bdad-47e56316f87b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("73aa364c-c2be-48b7-9f8c-dc7b5ca4fce9")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("73aa364c-c2be-48b7-9f8c-dc7b5ca4fce9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonSave item.
            /// </summary>
            [RepositoryItem("8041acb4-e08b-44f6-bdad-47e56316f87b")]
            public virtual Ranorex.Button ButtonSave
            {
                get
                {
                    return _buttonsaveInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonSave item info.
            /// </summary>
            [RepositoryItemInfo("8041acb4-e08b-44f6-bdad-47e56316f87b")]
            public virtual RepoItemInfo ButtonSaveInfo
            {
                get
                {
                    return _buttonsaveInfo;
                }
            }
        }

        /// <summary>
        /// The ConfirmSaveAsAppFolder folder.
        /// </summary>
        [RepositoryFolder("09fe4d9c-c61d-4430-b3fc-6f30e375d12f")]
        public partial class ConfirmSaveAsAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonyesInfo;

            /// <summary>
            /// Creates a new ConfirmSaveAs  folder.
            /// </summary>
            public ConfirmSaveAsAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ConfirmSaveAs", "/form[@title='Confirm Save As']", parentFolder, 30000, null, true, "09fe4d9c-c61d-4430-b3fc-6f30e375d12f", "")
            {
                _buttonyesInfo = new RepoItemInfo(this, "ButtonYes", "?/?/element[@instance='0']/button[@text='&Yes']", ".//button[@text='&Yes']", 30000, null, "8ac8f994-6633-46f4-a23a-6288db73f3f6");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("09fe4d9c-c61d-4430-b3fc-6f30e375d12f")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("09fe4d9c-c61d-4430-b3fc-6f30e375d12f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonYes item.
            /// </summary>
            [RepositoryItem("8ac8f994-6633-46f4-a23a-6288db73f3f6")]
            public virtual Ranorex.Button ButtonYes
            {
                get
                {
                    return _buttonyesInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonYes item info.
            /// </summary>
            [RepositoryItemInfo("8ac8f994-6633-46f4-a23a-6288db73f3f6")]
            public virtual RepoItemInfo ButtonYesInfo
            {
                get
                {
                    return _buttonyesInfo;
                }
            }
        }

        /// <summary>
        /// The EditColoursAppFolder folder.
        /// </summary>
        [RepositoryFolder("8703978d-4818-40ed-b46d-9dc772776d7e")]
        public partial class EditColoursAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _text706Info;
            RepoItemInfo _text720Info;
            RepoItemInfo _buttonokInfo;

            /// <summary>
            /// Creates a new EditColours  folder.
            /// </summary>
            public EditColoursAppFolder(RepoGenBaseFolder parentFolder) :
                    base("EditColours", "/form[@title='Edit Colours']", parentFolder, 30000, null, true, "8703978d-4818-40ed-b46d-9dc772776d7e", "")
            {
                _text706Info = new RepoItemInfo(this, "Text706", "text[@controlid='706']", "text[@controlid='706']", 30000, null, "cb4d3c04-70c2-4cad-8411-162813c1d065");
                _text720Info = new RepoItemInfo(this, "Text720", "text[@controlid='720']", "text[@controlid='720']", 30000, null, "7716ca5d-55a3-405b-9819-bfedfd158bae");
                _buttonokInfo = new RepoItemInfo(this, "ButtonOK", "button[@text='OK']", "button[@text='OK']", 30000, null, "dab67958-6118-430c-969f-eadff3867312");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("8703978d-4818-40ed-b46d-9dc772776d7e")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("8703978d-4818-40ed-b46d-9dc772776d7e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Text706 item.
            /// </summary>
            [RepositoryItem("cb4d3c04-70c2-4cad-8411-162813c1d065")]
            public virtual Ranorex.Text Text706
            {
                get
                {
                    return _text706Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text706 item info.
            /// </summary>
            [RepositoryItemInfo("cb4d3c04-70c2-4cad-8411-162813c1d065")]
            public virtual RepoItemInfo Text706Info
            {
                get
                {
                    return _text706Info;
                }
            }

            /// <summary>
            /// The Text720 item.
            /// </summary>
            [RepositoryItem("7716ca5d-55a3-405b-9819-bfedfd158bae")]
            public virtual Ranorex.Text Text720
            {
                get
                {
                    return _text720Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text720 item info.
            /// </summary>
            [RepositoryItemInfo("7716ca5d-55a3-405b-9819-bfedfd158bae")]
            public virtual RepoItemInfo Text720Info
            {
                get
                {
                    return _text720Info;
                }
            }

            /// <summary>
            /// The ButtonOK item.
            /// </summary>
            [RepositoryItem("dab67958-6118-430c-969f-eadff3867312")]
            public virtual Ranorex.Button ButtonOK
            {
                get
                {
                    return _buttonokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonOK item info.
            /// </summary>
            [RepositoryItemInfo("dab67958-6118-430c-969f-eadff3867312")]
            public virtual RepoItemInfo ButtonOKInfo
            {
                get
                {
                    return _buttonokInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
