using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml;
using System.Xml.Schema;
namespace AST_Code_Generation
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ViewModel()
        {
            MouseMoveObservable = new Subject<MouseData>();
            MouseUpObservable = new Subject<MouseData>();
            LineObservable = new Subject<MouseData>();
            mouseUpCommand = new RelayCommand(MouseUp);
            mouseMoveCommand = new RelayCommand(MouseMove);
            mouseDownCommand = new RelayCommand(MouseDown);
            mouseDoubleClickCommand = new RelayCommand(MouseDoubleClick);
            m_UpCommand = new RelayCommand(MouseUpCommand_Line);
            ShowWindowCommand = new RelayCommand(ShowWindow);
            generateCommand = new RelayCommand(Generate);
            saveCommand = new RelayCommand(Save);
            loadCommand = new RelayCommand(Load);
            //Remove Nodes
            removeCommand = new RelayCommand(Remove);
            //Remove Lines
            removeLineCommand = new RelayCommand(remove);
            observableRectangles = new ObservableCollection<AbstractNode>();
            observableRectangles.Add(new SpaceNode("Start", 25, 35));
            //observableRectangles.Add(new OpNode("Op", 25, 80));
            //observableRectangles.Add(new VarNode("Var", 25, 125));
            observableRectangles.Add(new ConstantNode("Const", 25, 80));
            //observableRectangles.Add(new IfNode("If", 25, 125));
            observableRectangles.Add(new GaussianArrayNode("GaussArr", 25, 125));
            //observableRectangles.Add(new ForNode("For", 25, 260);
            observableRectangles.Add(new AndNode("And", 25, 170));
            observableRectangles.Add(new BernoulliNode("Bernoulli", 25, 215));
            observableRectangles.Add(new ObservedBernoulliNode("ObsBernoli", 25, 260));
            //observableRectangles.Add(new WhileNode("While", 25, 305));
            observableRectangles.Add(new ObservedGaussianNode("ObsGauss", 25, 305));
            observableRectangles.Add(new ArrayNode("Array", 25, 350));
            observableRectangles.Add(new RangeNode("Range", 25, 395));            
            observableRectangles.Add(new ForEachNode("ForEach", 25, 440));
            observableRectangles.Add(new VariableArrayNode("VarArray", 25, 485));
            observableRectangles.Add(new GaussianNode("Gaussian", 25, 530));
            observableRectangles.Add(new GammaNode("Gamma", 25, 575));
            observableRectangles.Add(new ObservedValueNode("ObserveVal", 25, 620));
            observableRectangles.Add(new ConstrainNode("Constrian", 25, 665));
            observableRectangles.Add(new EngineNode("Engine", 25, 710));
            observableRectangles.Add(new InferNode("Infer", 25, 755));
            //observableRectangles.Add(new RandVarNode("RandVar", 25, 755));
            observableLines = new ObservableCollection<ArtificialLine>();
            observableButtons = new ObservableCollection<MyButton>();
            observableRemove = new ObservableCollection<MyButton>();
            
        }
        /****************************************************************************************************************************/
        private int a = 0;

        private ObservableCollection<MyButton> observableRemove;
        public ObservableCollection<MyButton> ObservableRemove
        {
            get { return observableRemove; }
            set { observableRemove = value; OnPropertyChanged("ObservableRemove"); }
        }

        private RelayCommand removeLineCommand;
        public RelayCommand RemoveLineCommand
        {
            get { return removeLineCommand; }
            set { removeLineCommand = value; OnPropertyChanged("RemoveLineCommand"); }
        }

        private ObservableCollection<MyButton> observableButtons;
        public ObservableCollection<MyButton> ObservableButtons
        {
            get { return observableButtons; }
            set { observableButtons = value; OnPropertyChanged("ObservableButtons"); }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get { return removeCommand; }
            set { removeCommand = value; OnPropertyChanged("RemoveCommand"); }
        }


        private ObservableCollection<ArtificialLine> observableLines;
        public ObservableCollection<ArtificialLine> ObservableLines
        {
            get { return observableLines; }
            set { observableLines = value; OnPropertyChanged("ObservableLines"); }
        }

        private ObservableCollection<AbstractNode> observableRectangles;
        public ObservableCollection<AbstractNode> ObservableRectangles
        {
            get { return observableRectangles; }
            set { observableRectangles = value; OnPropertyChanged("ObservableRectangles"); }
        }

        public Subject<MouseData> MouseMoveObservable { get; set; }
        public Subject<MouseData> MouseUpObservable { get; set; }
        private Subject<MouseData> lineObservable;

        public Subject<MouseData> LineObservable
        {
            get { return lineObservable; }
            set { lineObservable = value; }
        }

        private RelayCommand mouseUpCommand;
        public RelayCommand MouseUpCommand
        {
            get { return mouseUpCommand; }
        }

        private RelayCommand mouseMoveCommand;
        public RelayCommand MouseMoveCommand
        {
            get { return mouseMoveCommand; }
        }

        private RelayCommand generateCommand;
        public RelayCommand GenerateCommand
        {
            get { return generateCommand; }
        }

        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get { return saveCommand; }
        }

        private RelayCommand loadCommand;
        public RelayCommand LoadCommand
        {
            get { return loadCommand; }
        }

        private RelayCommand mouseDownCommand;
        public RelayCommand MouseDownCommand
        {
            get { return mouseDownCommand; }
        }

        private RelayCommand mouseDoubleClickCommand;
        public RelayCommand MouseDoubleClickCommand
        {
            get { return mouseDoubleClickCommand; }
        }

        private RelayCommand m_UpCommand;
        public RelayCommand M_UpCommand
        {
            get { return m_UpCommand; }
            set { m_UpCommand = value; OnPropertyChanged("M_UpCommand"); }
        }

        private RelayCommand showWindowCommand;
        public RelayCommand ShowWindowCommand
        {
            get { return showWindowCommand; }
            set { showWindowCommand = value; OnPropertyChanged("ShowWindowCommand"); }
        }

        public void MouseMove(object parameter)
        {            
            if (parameter != null)
            {
                MouseMoveObservable.OnNext((MouseData)parameter);
            }
        }

        public void MouseUp(object parameter)
        {
            if (parameter != null)
            {
                MouseUpObservable.OnNext((MouseData)parameter);
            }
        }

        public void MouseUpCommand_Line(object parameter)
        {
            if (parameter != null)
            {
                //LineObservable.OnNext((MouseData)parameter);
            }
        }

        private void Save(object obj)
        {
            SaveModel();
        }

        private void Load(object obj)
        {
            LoadModel();
        }

        /**************************************************************************************************************************/
        private void Generate(object obj)
        {
            Visitor v = new Visitor();
            string code = "";
            foreach (AbstractNode j in observableRectangles)
            {
                j.IsVisited = false;
            }
            foreach (AbstractNode i in observableRectangles)
            {
                //if (i.Parent == null && i.Original == 0)
                if (i.Children.ToArray().Length == 0 && i.Original == 0)
                {
                    code = v.generate(i);
                }
            }
            foreach (AbstractNode i in observableRectangles)
            {
                //if (i.Parent == null && i.Original == 0)
                if (i is ObservedGaussianNode && i.Original == 0)
                {
                    //string code = v.generate(i);
                    //MessageBox.Show(code);
                    code += i.Title + ".ObservedValue = " + ((ObservedGaussianNode)i).ObservedValue + ";\n";
                }
                else if (i is ObservedBernoulliNode && i.Original == 0)
                {
                    code += i.Title + ".ObservedValue = " + ((ObservedBernoulliNode)i).TrueORfalse + ";\n";
                }
            }
            code += "InferenceEngine engine = new InferenceEngine();\n";
            foreach (AbstractNode i in observableRectangles)
            {
                //if (i.Parent == null && i.Original == 0)
                if (i is GaussianNode && i.Original == 0)
                {
                    code += "Gaussian " + i.Title + "Posterior = engine.Infer<Gaussian>(" + i.Title + ");\n";
                }
                else if (i is GaussianArrayNode && i.Original == 0)
                {
                    code += "Gaussian[] " + i.Title + "Posterior = engine.Infer<Gaussian[]>(" + i.Title + ");\n";
                }
                else if (i is GammaNode && i.Original == 0)
                {
                    code += "Gamma " + i.Title + "Posterior = engine.Infer<Gamma>(" + i.Title + ");\n";
                }
                else if (i is BernoulliNode && i.Original == 0)
                {
                    code += "Bernoulli " + i.Title + "Posterior = engine.Infer<Bernoulli>(" + i.Title + ");\n";
                }
            }
            MessageBox.Show(code, "Code", MessageBoxButton.OK);
        }

        private void ShowWindow(object obj)
        {
            MyButton Bu = (MyButton)obj;
            // Bu.MyNode.Window_.Show();
            Bu.MyNode.Show_Win();
        }

        private void CreateButtons(AbstractNode parCopy)
        {
            MyButton bu = new MyButton();
            bu.MyNode = parCopy;
            observableRemove.Add(bu);
            parCopy.Remove_btn = bu;
            //Nodes which not have a properties window
            if (!((parCopy is IfNode)||(parCopy is SpaceNode))||(parCopy is ObservedValueNode))
            {
                MyButton newButton = new MyButton();
                newButton.CanvasLeft = parCopy.CanvasLeft + 55;
                newButton.CanvasTop = parCopy.CanvasTop;
                newButton.MyNode = parCopy;
                bu.B = newButton;
                parCopy.Prop_btn = newButton;
                observableButtons.Add(newButton);
                //newButton.CanvasLeft = parCopy.CanvasLeft + 25;
                //newButton.CanvasTop = parCopy.CanvasTop;
                bu.CanvasLeft = parCopy.CanvasLeft;
                bu.CanvasTop = parCopy.CanvasTop + 1;   
            }
            else
            {               
                bu.CanvasLeft = parCopy.CanvasLeft;
                bu.CanvasTop = parCopy.CanvasTop + 1;
            }
            parCopy.Original = 0;
        }

        private AbstractNode GetNodeAtCanvas(double canvasLeft, double canvasTop)
        {
            AbstractNode Node= null;
            foreach (AbstractNode Rect in observableRectangles.ToList())
            {
                if ((Rect.CanvasLeft == canvasLeft)&& (Rect.CanvasTop == canvasTop))
                {
                    Node = Rect;
                    break;
                }
                // Model.AppendLine(Rect.Title + ',' + Rect.CanvasLeft + ',' + Rect.CanvasTop);
            }
            return Node;
        }

        public void MouseDoubleClick(object parameter)
        {
            MessageBox.Show("double clicked");
        }

        public void MouseDown(object parameter) {
            AbstractNode par = (AbstractNode)parameter;
          
            if (parameter != null)
            {
                //Original was set to 1 initially in the NonBinaryNode's constructor                
                if (par.Original != 0)
                {
                    AbstractNode parCopy = (AbstractNode)Activator.CreateInstance(par.GetType(), new object[] { par.Title });
                    parCopy.CanvasLeft = par.CanvasLeft;
                    parCopy.CanvasTop = par.CanvasTop;
                    parCopy.Mouse_Data.X = par.Mouse_Data.X;
                    parCopy.Mouse_Data.Y = par.Mouse_Data.Y;
                    parCopy.Mouse_Data.IsDragged = par.Mouse_Data.IsDragged;
                    MyButton bu = new MyButton();
                    parCopy.Remove_btn = bu;
                    bu.MyNode = parCopy;
                    observableRemove.Add(bu);
                    if (parCopy.GetType().ToString() != "AST_Code_Generation.IfNode" && parCopy.GetType().ToString() != "AST_Code_Generation.SpaceNode" && parCopy.GetType().ToString() != "AST_Code_Generation.ObservedValueNode")
                    {
                        MyButton newButton = new MyButton();
                        newButton.CanvasLeft = parCopy.CanvasLeft + 55;
                        newButton.CanvasTop = parCopy.CanvasTop;
                        newButton.MyNode = parCopy;
                        bu.B = newButton;
                        parCopy.Prop_btn = newButton;
                        ObservableRectangles.Add(parCopy);
                        observableButtons.Add(newButton);
                        var m_up = from m_data in MouseUpObservable where m_data.X > 110 select m_data;
                        var q = from s in parCopy.MouseDownObservable from pos in MouseMoveObservable.TakeUntil(m_up) select pos;
                        q.Subscribe(value =>
                        {
                            parCopy.CanvasLeft = value.X;
                            parCopy.CanvasTop = value.Y;
                            newButton.CanvasLeft = parCopy.CanvasLeft + 55;
                            newButton.CanvasTop = parCopy.CanvasTop;
                            bu.CanvasLeft = parCopy.CanvasLeft;
                            bu.CanvasTop = parCopy.CanvasTop + 1;
                        });
                        
                    }
                    else
                    {
                        ObservableRectangles.Add(parCopy);

                        var m_up = from m_data in MouseUpObservable where m_data.X > 110 select m_data;
                        var q = from s in parCopy.MouseDownObservable from pos in MouseMoveObservable.TakeUntil(m_up) select pos;
                        q.Subscribe(value =>
                        {
                            parCopy.CanvasLeft = value.X;
                            parCopy.CanvasTop = value.Y;
                            bu.CanvasLeft = parCopy.CanvasLeft;
                            bu.CanvasTop = parCopy.CanvasTop + 1;
                        });
                    }
                    
                    parCopy.MouseDownObservable.OnNext(parCopy.Mouse_Data);
                    parCopy.Original = 0;
                }
                else if(a == 0)//line creation
                {
                    if(par.Mouse_Data.IsLeftPressed)
                    {
                        if (par.CanvasLeft > 110)
                        {
                            ArtificialLine line = new ArtificialLine();
                            line.St_node = par;
                            line.Starting.X = par.CanvasLeft + 35;///
                            line.Starting.Y = par.CanvasTop + 40;
                            line.Ending.X = par.CanvasLeft + 35;
                            line.Ending.Y = par.CanvasTop + 40;

                            ObservableLines.Add(line);

                            var m_up = from m_data in LineObservable select m_data;
                            var q = from pos in MouseMoveObservable.TakeUntil(m_up) select pos;
                            q.Subscribe(value =>
                            {
                                line.Ending.X = value.X - 1;
                                line.Ending.Y = value.Y - 1;
                            });
                            //m_up.Subscribe(value =>
                            //{
                            //    if (ObservableLines.Last().End_node == null)
                            //        ObservableLines.Remove(ObservableLines.Last());
                            //}
                            //    );
                            a = 1;
                        }

                    }
                    else
                    {
                        var m_up = from m_data in MouseUpObservable where m_data.X > 110 select m_data;
                        //var q = from s in par.MouseDownObservable from pos in MouseMoveObservable.TakeUntil(m_up) select pos;
                        var q = from pos in MouseMoveObservable.TakeUntil(m_up) select pos;

                        q.Subscribe(value =>
                        {
                            par.CanvasLeft = value.X;
                            par.CanvasTop = value.Y;
                            if(par.Prop_btn != null)
                            {
                                par.Prop_btn.CanvasLeft = par.CanvasLeft + 55;
                                par.Prop_btn.CanvasTop = par.CanvasTop;
                            }
                            par.Remove_btn.CanvasLeft = par.CanvasLeft;
                            par.Remove_btn.CanvasTop = par.CanvasTop + 1;
                        });
                    }                                      
                }
                else
                {
                    if (ObservableLines.Count == 0)
                    {
                        a = 0;
                    }
                    else if (par.CanvasLeft > 110)
                    {                        
                        LineObservable.OnNext(par.Mouse_Data);
                        ArtificialLine currentLine = ObservableLines.Last();
                        if (par != currentLine.St_node)
                        {
                            foreach (ArtificialLine Line in ObservableLines.ToList())
                            {

                                if(((Line.St_node == currentLine.St_node)&&(Line.End_node == par))
                                    || ((Line.End_node == currentLine.St_node) && (Line.St_node == par)))
                                {
                                    ObservableLines.Remove(Line);
                                }
                            }
                            par.Parent = currentLine.St_node;
                            par.addParent(currentLine.St_node);
                            currentLine.St_node.addChild(par);
                            currentLine.End_node = par;
                            currentLine.Ending.X = currentLine.End_node.CanvasLeft + 35;///
                            currentLine.Ending.Y = currentLine.End_node.CanvasTop + 1;                            
                        }
                        else
                        {
                            ObservableLines.Remove(currentLine);
                        }
                        a = 0;
                    }                    
                }
            }
            else
            {
                if (a==1)
                {
                    ObservableLines.Remove(ObservableLines.Last());
                    a = 0;
                }
            }        
        }
        /****************************************************************************************************************************/

        private const string begin = "<?xml version=\"1.0\" encoding=\"utf-8\"?> \n <AST>";
        private const string endStr = "</AST>";
        string Model_Path = "Model.xml";
        //string Model_Path = "";
        private void SaveModel()
        {
            StringBuilder Model = new StringBuilder();

           foreach (AbstractNode Rect in observableRectangles.ToList())
            {
                if(IsInsideDrawView(Rect.CanvasLeft, Rect.CanvasTop))
                {
                    Model.AppendLine(GetBlockXML(Rect));
                }
               // Model.AppendLine(Rect.Title+','+Rect.CanvasLeft + ',' + Rect.CanvasTop);
            }
            foreach (ArtificialLine Line in ObservableLines.ToList())
            {
                
                Model.AppendLine(GetBlockXML(Line));
                
            }
            // Create SaveFileDialog
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            // Display SaveFileDialog
            dlg.Filter = "XML files|*.xml|Text files|*.txt|Image files (*.bmp, *.jpg)|*.bmp;*.jpg|All files (*.*)|*.*";
            dlg.FileName = Model_Path;
            Nullable<bool> result = dlg.ShowDialog();
            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                Model_Path = dlg.FileName;                
                System.IO.File.WriteAllText(Model_Path, begin + "\r\n" + "\r\n" + Model.ToString()+endStr);
                MessageBox.Show("Model Saved to " + Model_Path, "Save", MessageBoxButton.OK);
            }
        }
        private void LoadModel()
        {
			// Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.Filter = "XML files|*.xml|Text files|*.txt|Image files (*.bmp, *.jpg)|*.bmp;*.jpg|All files (*.*)|*.*";
            // Display OpenFileDialog  
            Nullable<bool> result = dlg.ShowDialog();
            // Process load file dialog box results
            if (result == true)
            {
                // Open document 
                Model_Path = dlg.FileName;
                StringBuilder Model = new StringBuilder(System.IO.File.ReadAllText(Model_Path));
                XmlDocument doc = new XmlDocument();
                try
                {
                    doc.Load(Model_Path);
                    if(observableRemove.Count>0)
                    {
                        foreach (MyButton btn in observableRemove.ToList())
                        {
                            Remove(btn);
                        }
                    }
                    
                    AddBlockNodes(doc.DocumentElement.ChildNodes);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Invalid File : " + e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }            
        }
        private string GetBlockXML(object node_obj)//save nodes , extract text of current node
        {
            StringBuilder sb = new StringBuilder();
            string nodeName = "";
            if (node_obj is AbstractNode)
            {
                AbstractNode node = (AbstractNode)node_obj;
                sb.Append(GetElementAttXML("Title", node.Title));
                sb.Append(GetElementAttXML("CanvasLeft", node.CanvasLeft.ToString()));
                sb.Append(GetElementAttXML("CanvasTop", node.CanvasTop.ToString()));
               
                if (node is OpNode)
                {
                    nodeName = "Op";
                }
                else if (node is VarNode)
                {
                    nodeName = "Var";
                }
                else if (node is ConstantNode)
                {
                    nodeName = "Const";
                }
                else if (node is IfNode)
                {
                    nodeName = "If";
                }
                else if (node is ForNode)
                {
                    nodeName = "For";
                    sb.Append(GetElementAttXML("Value1", ((ForNode)node).r.Start.ToString()));
                    sb.Append(GetElementAttXML("Value2", ((ForNode)node).r.End.ToString()));
                }
                else if (node is SpaceNode)
                {
                    nodeName = "Start";
                }
                //else if (node is WhileNode)
                //{
                //    nodeName = "While";
                //    sb.Append(GetElementAttXML("Value1", ((WhileNode)node).r.Start.ToString()));
                //    sb.Append(GetElementAttXML("Value2", ((WhileNode)node).r.End.ToString()));
                //}
                else if (node is ObservedGaussianNode)
                {
                    nodeName = "ObsGauss";
                    sb.Append(GetElementAttXML("Value1", ((ObservedGaussianNode)node).ObservedValue));
                }
                else if (node is ArrayNode)
                {
                    nodeName = "Array";
                    sb.Append(GetElementAttXML("Value1", ((ArrayNode)node).ArrayString));
                    sb.Append(GetElementAttXML("Value2", ((ArrayNode)node).Type));
                }                
                else if (node is RangeNode)
                {
                    nodeName = "Range";
                    sb.Append(GetElementAttXML("Value", ((RangeNode)node).RangeValue));
                }
                else if (node is ForEachNode)
                {
                    nodeName = "ForEach";
                    sb.Append(GetElementAttXML("Value", ((ForEachNode)node).Range));
                }
                else if (node is VariableArrayNode)
                {
                    nodeName = "VarArray";
                    sb.Append(GetElementAttXML("Value1", ((VariableArrayNode)node).Range));
                    sb.Append(GetElementAttXML("Value2", ((VariableArrayNode)node).Type));
                }
                else if (node is GaussianNode)
                {
                    nodeName = "Gaussian";
                    sb.Append(GetElementAttXML("Value1", ((GaussianNode)node).Mean));
                    sb.Append(GetElementAttXML("Value2", ((GaussianNode)node).Variance));
                }
                else if (node is GammaNode)
                {
                    nodeName = "Gamma";
                    sb.Append(GetElementAttXML("Value1", ((GammaNode)node).Alpha));
                    sb.Append(GetElementAttXML("Value2", ((GammaNode)node).Beta));
                }
                else if (node is ObservedValueNode)
                {
                    nodeName = "ObserveVal";
                }
                else if (node is ConstrainNode)
                {
                    nodeName = "Constrain";//??
                }
                else if (node is EngineNode)
                {
                    nodeName = "Engine";
                    sb.Append(GetElementAttXML("Value1", ((EngineNode)node).Algorithm));
                    sb.Append(GetElementAttXML("Value2", ((EngineNode)node).NumberOfIterations));
                }
                else if (node is InferNode)
                {
                    nodeName = "Infer";
                    sb.Append(GetElementAttXML("Value1", ((InferNode)node).EngineName));
                    sb.Append(GetElementAttXML("Value2", ((InferNode)node).Type));
                    sb.Append(GetElementAttXML("Value3", ((InferNode)node).Observale));
                }
                else if (node is AndNode)
                {
                    nodeName = "And";//??
                }
                else if (node is BernoulliNode)
                {
                    nodeName = "Bernoulli";//??
                }
                else if (node is ObservedBernoulliNode)
                {
                    nodeName = "ObsBernoli";
                    sb.Append(GetElementAttXML("Value1", ((ObservedBernoulliNode)node).ValueWhenTrue));
                    sb.Append(GetElementAttXML("Value2", ((ObservedBernoulliNode)node).ValueWhenFalse));
                    sb.Append(GetElementAttXML("Value3", ((ObservedBernoulliNode)node).TrueORfalse));
                }
            }
            else if (node_obj is ArtificialLine)
            {
                ArtificialLine node = (ArtificialLine)node_obj;
                sb.Append(GetElementAttXML("Starting_X", node.Starting.X.ToString()));
                sb.Append(GetElementAttXML("Starting_Y", node.Starting.Y.ToString()));
                sb.Append(GetElementAttXML("Ending_X", node.Ending.X.ToString()));
                sb.Append(GetElementAttXML("Ending_Y", node.Ending.Y.ToString()));
                nodeName = "line";
            }
            return GetElementXML(nodeName, sb.ToString());
        }
        private string GetElementXML(string name,string value)
        {
            string element = "    <" + name + value + ">" + "\r\n" + "    </" + name + "> \n";// + "\r\n";
            return element;
        }
        private string GetElementAttXML(string name, string value)
        {
            string element = " " + name + " = " + '"' + value + '"' + " ";
            return element;
        }
        private void AddBlockNodes(XmlNodeList list)
        {
            foreach (XmlNode node in list)
            {
                string node_name = node.Name;
                
                if ((node_name=="Op")||(node_name == "Var")||(node_name == "Const")||(node_name == "If")||(node_name == "For")||
                    (node_name == "Start")||(node_name == "ObsGauss")||(node_name == "Array")||(node_name == "Range")||
                    (node_name == "ForEach")||(node_name == "VarArray")||(node_name == "Gaussian")|| (node_name == "Gamma") ||
                    (node_name == "ObserveVal")|| (node_name == "Constrain")|| (node_name == "Engine")|| (node_name == "Infer")||
                    (node_name == "And")||(node_name == "Bernoulli")||(node_name == "ObsBernoli"))
                {
                    string variable_title = node.Attributes["Title"].InnerText;
                    double variable_CanLeft = Double.Parse(node.Attributes["CanvasLeft"].InnerText);
                    double variable_CanTop = Double.Parse(node.Attributes["CanvasTop"].InnerText);
                    
                    if (node.Name.Equals("Op"))
                    {
                        OpNode node_class = new OpNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                    }
                    else if (node.Name.Equals("Var"))
                    {
                        VarNode node_class= new VarNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                    }
                    else if (node.Name.Equals("Const"))
                    {
                        ConstantNode node_class = new ConstantNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                    }
                    else if (node.Name.Equals("If"))
                    {
                        IfNode node_class = new IfNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                    }
                    else if (node.Name.Equals("For"))
                    {
                        ForNode node_class = new ForNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.r = new Range(Int32.Parse(node.Attributes["Value1"].InnerText), Int32.Parse(node.Attributes["Value2"].InnerText));
                    }
                    else if (node.Name.Equals("Start"))
                    {
                        SpaceNode node_class = new SpaceNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                    }
                    //else if (node.Name.Equals("While"))
                    //{
                    //    WhileNode node_class = new WhileNode(variable_title, variable_CanLeft, variable_CanTop);
                    //    observableRectangles.Add(node_class);
                    //    CreateButtons(node_class);
                    //    node_class.r = new Range(Int32.Parse(node.Attributes["Value1"].InnerText), Int32.Parse(node.Attributes["Value2"].InnerText));
                    //}
                    else if (node.Name.Equals("ObsGauss"))
                    {
                        ObservedGaussianNode node_class = new ObservedGaussianNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.ObservedValue = node.Attributes["Value1"].InnerText;
                    }
                    else if (node.Name.Equals("Array"))
                    {
                        ArrayNode node_class = new ArrayNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.ArrayString = node.Attributes["Value1"].InnerText;
                        node_class.Type = node.Attributes["Value2"].InnerText;

                    }
                    else if (node.Name.Equals("Range"))
                    {
                        RangeNode node_class = new RangeNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.RangeValue = node.Attributes["Value"].InnerText;
                    }
                    else if (node.Name.Equals("ForEach"))
                    {
                        ForEachNode node_class = new ForEachNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.Range = node.Attributes["Value"].InnerText;
                    }
                    else if (node.Name.Equals("VarArray"))
                    {
                        VariableArrayNode node_class = new VariableArrayNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.Range = node.Attributes["Value1"].InnerText;
                        node_class.Type = node.Attributes["Value2"].InnerText;
                    }
                    else if (node.Name.Equals("Gaussian"))
                    {
                        GaussianNode node_class = new GaussianNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.Mean = node.Attributes["Value1"].InnerText;
                        node_class.Variance = node.Attributes["Value2"].InnerText;
                    }
                    else if (node.Name.Equals("Gamma"))
                    {
                        GammaNode node_class = new GammaNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.Alpha = node.Attributes["Value1"].InnerText;
                        node_class.Beta = node.Attributes["Value2"].InnerText;
                    }
                    else if (node.Name.Equals("ObserveVal"))
                    {
                        ObservedValueNode node_class = new ObservedValueNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                    }
                    else if (node.Name.Equals("Constrain"))
                    {
                        ConstrainNode node_class = new ConstrainNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                    }
                    else if (node.Name.Equals("Engine"))
                    {
                        EngineNode node_class = new EngineNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.Algorithm = node.Attributes["Value1"].InnerText;
                        node_class.NumberOfIterations = node.Attributes["Value2"].InnerText;
                    }
                    else if (node.Name.Equals("Infer"))
                    {
                        InferNode node_class = new InferNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.EngineName = node.Attributes["Value1"].InnerText;
                        node_class.Type = node.Attributes["Value2"].InnerText;
                        node_class.Observale = node.Attributes["Value3"].InnerText;
                    }
                    else if (node.Name.Equals("And"))
                    {
                        AndNode node_class = new AndNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                    }
                    else if (node.Name.Equals("Bernoulli"))
                    {
                        BernoulliNode node_class = new BernoulliNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                    }
                    else if (node.Name.Equals("ObsBernoli"))
                    {
                        ObservedBernoulliNode node_class = new ObservedBernoulliNode(variable_title, variable_CanLeft, variable_CanTop);
                        observableRectangles.Add(node_class);
                        CreateButtons(node_class);
                        node_class.ValueWhenTrue = node.Attributes["Value1"].InnerText;
                        node_class.ValueWhenFalse = node.Attributes["Value2"].InnerText;
                        node_class.TrueORfalse = node.Attributes["Value3"].InnerText;
                    }
                }
                else if (node.Name.Equals("line"))
                {
                    ArtificialLine currentLine = new ArtificialLine();
                    currentLine.Starting.X = Double.Parse(node.Attributes["Starting_X"].InnerText);
                    currentLine.Starting.Y = Double.Parse(node.Attributes["Starting_Y"].InnerText);
                    currentLine.Ending.X = Double.Parse(node.Attributes["Ending_X"].InnerText);
                    currentLine.Ending.Y = Double.Parse(node.Attributes["Ending_Y"].InnerText);
                    currentLine.St_node = GetNodeAtCanvas(currentLine.Starting.X - 35, currentLine.Starting.Y - 40);
                    currentLine.End_node = GetNodeAtCanvas(currentLine.Ending.X - 35, currentLine.Ending.Y - 1);
                    currentLine.End_node.Parent = currentLine.St_node;
                    currentLine.End_node.addParent(currentLine.St_node);
                    currentLine.St_node.addChild(currentLine.End_node);
                    ObservableLines.Add(currentLine);
                }
            }
        }

        Boolean IsInsideDrawView(double CanvasLeft, double CanvasTop)
        {
            if (CanvasLeft > 110)
            {
                return true;
            }
            return false;
        }

        private void Remove(object obj)
        {
            MyButton button_ = (MyButton)obj;
            foreach (ArtificialLine i in ObservableLines.ToList())
            {
                if ((i.St_node == button_.MyNode) || (i.End_node == button_.MyNode))
                {
                    ObservableLines.Remove(i);
                }
            }
            observableRectangles.Remove(button_.MyNode);
            observableRemove.Remove(button_);
            if(button_.B != null)
            {
                observableButtons.Remove(button_.B);
            }
            if(button_.MyNode.Parent != null)
            {
                button_.MyNode.Parent.Children.Remove(button_.MyNode);
            }
            
            foreach (AbstractNode i in button_.MyNode.Children)
            {
                i.Parent = null;
            }
        }

        private void remove(object obj)
        {
            ArtificialLine L = (ArtificialLine)obj;
            if (L.End_node == null)
                return;
            L.St_node.Children.Remove(L.End_node);            
            L.End_node.Parent = null;
            observableLines.Remove(L);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
