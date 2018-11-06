using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace PlaceTowers
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Ellipse.Visibility = Visibility.Hidden;
        }

        //private bool isDragging;
        private bool _isClicked;
        private Rectangle _buyTower;

        #region Drag and Drop - could not get this to work probably.

        // Inspiration sources:
        // https://stackoverflow.com/questions/5659237/make-object-follow-mouse-on-mousedown-and-stick-on-mouseup

        //private void TowerRed_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    cloneTower = new Rectangle
        //    {
        //        Width = TowerRed.Width,
        //        Height = TowerRed.Height,
        //        Fill = Brushes.Blue,
        //        Opacity = 50
        //    };

        //    Map.Children.Add(cloneTower);
        //    Canvas.SetLeft(cloneTower, Canvas.GetLeft(TowerRed));
        //    Canvas.SetTop(cloneTower, Canvas.GetTop(TowerRed));

        //    cloneTower.CaptureMouse();

        //    isDragging = !isDragging;
        //    if (!isDragging)
        //        cloneTower.ReleaseMouseCapture();
        //}

        //private void CloneTower_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isDragging)
        //    {
        //        var canvPosToWindow = Map.TransformToAncestor(this).Transform(new Point(0, 0));
        //        var r = sender as Rectangle;

        //        var upperLimit = canvPosToWindow.Y + r.Height / 2;
        //        var lowerLimit = canvPosToWindow.Y + Map.ActualHeight - r.Height / 2;
        //        var leftLimit = canvPosToWindow.X + r.Width / 2;
        //        var rightLimit = canvPosToWindow.X + Map.ActualWidth - r.Width / 2;

        //        var absMouseXPos = e.GetPosition(this).X;
        //        var absMouseYPos = e.GetPosition(this).Y;

        //        if (absMouseXPos > leftLimit && absMouseXPos < rightLimit && absMouseYPos > upperLimit && absMouseYPos < lowerLimit)
        //        {
        //            r.SetValue(Canvas.LeftProperty, e.GetPosition(Map).X - r.Width / 2);
        //            r.SetValue(Canvas.TopProperty, e.GetPosition(Map).Y - r.Height / 2);
        //        }
        //    }
        //}

        #endregion


        #region Select and place.

        private void TowerRed_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _buyTower = sender as Rectangle;
            _isClicked = !_isClicked;
            TowerRed.Stroke = _isClicked ? Brushes.Black : null;
        }

        private void TowerPlacement1_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_buyTower == null) return;

            var placingTower = new Rectangle
            {
                Width = _buyTower.Width,
                Height = _buyTower.Height,
                Fill = Brushes.Red
            };

            Map.Children.Add(placingTower);
            Canvas.SetLeft(placingTower, Canvas.GetLeft(TowerPlacement1));
            Canvas.SetTop(placingTower, Canvas.GetTop(TowerPlacement1));

            _buyTower = null;
            TowerRed.Stroke = null;
            _isClicked = false;

            // Creating Tower Cover Area Circle:
            var coverArea = new Ellipse()
            {
                Name = "coverArea1",
                Width = 120,
                Height = 120,
                Fill = new SolidColorBrush(Color.FromArgb(40, 0, 0, 255)),
                Stroke = new SolidColorBrush(Color.FromArgb(65, 0, 0, 0)),
            };

            Map.Children.Add(coverArea);
            Canvas.SetLeft(coverArea, Canvas.GetLeft(TowerPlacement1) - TowerPlacement1.Width);
            Canvas.SetTop(coverArea, Canvas.GetTop(TowerPlacement1) - TowerPlacement1.Height);

            placingTower.MouseEnter += PlacingTower_MouseEnter;
        }

        private void PlacingTower_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Entered");
            Visibility = Visibility.Visible;
        }

        #region The other towers
        private void TowerPlacement2_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_buyTower == null) return;

            var placingTower = new Rectangle
            {
                Width = _buyTower.Width,
                Height = _buyTower.Height,
                Fill = Brushes.Red
            };

            Map.Children.Add(placingTower);
            Canvas.SetLeft(placingTower, Canvas.GetLeft(TowerPlacement2));
            Canvas.SetTop(placingTower, Canvas.GetTop(TowerPlacement2));

            _buyTower = null;
            TowerRed.Stroke = null;
            _isClicked = false;

            // Creating Tower Cover Area Circle:
            var coverArea = new Ellipse()
            {
                Name = "coverArea2",
                Width = 120,
                Height = 120,
                Fill = new SolidColorBrush(Color.FromArgb(40, 0, 0, 255)),
                Stroke = new SolidColorBrush(Color.FromArgb(65, 0, 0, 0))
            };

            Map.Children.Add(coverArea);
            Canvas.SetLeft(coverArea, Canvas.GetLeft(TowerPlacement2) - TowerPlacement2.Width);
            Canvas.SetTop(coverArea, Canvas.GetTop(TowerPlacement2) - TowerPlacement2.Height);
        }

        private void TowerPlacement3_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_buyTower == null) return;

            var placingTower = new Rectangle
            {
                Width = _buyTower.Width,
                Height = _buyTower.Height,
                Fill = Brushes.Red
            };

            Map.Children.Add(placingTower);
            Canvas.SetLeft(placingTower, Canvas.GetLeft(TowerPlacement3));
            Canvas.SetTop(placingTower, Canvas.GetTop(TowerPlacement3));

            _buyTower = null;
            TowerRed.Stroke = null;
            _isClicked = false;

            // Creating Tower Cover Area Circle:
            var coverArea = new Ellipse()
            {
                Name = "coverArea3",
                Width = 120,
                Height = 120,
                Fill = new SolidColorBrush(Color.FromArgb(40, 0, 0, 255)),
                Stroke = new SolidColorBrush(Color.FromArgb(65, 0, 0, 0))
            };

            Map.Children.Add(coverArea);
            Canvas.SetLeft(coverArea, Canvas.GetLeft(TowerPlacement3) - TowerPlacement3.Width);
            Canvas.SetTop(coverArea, Canvas.GetTop(TowerPlacement3) - TowerPlacement3.Height);
        }

        private void TowerPlacement4_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_buyTower == null) return;

            var placingTower = new Rectangle
            {
                Width = _buyTower.Width,
                Height = _buyTower.Height,
                Fill = Brushes.Red
            };

            Map.Children.Add(placingTower);
            Canvas.SetLeft(placingTower, Canvas.GetLeft(TowerPlacement4));
            Canvas.SetTop(placingTower, Canvas.GetTop(TowerPlacement4));

            _buyTower = null;
            TowerRed.Stroke = null;
            _isClicked = false;

            // Creating Tower Cover Area Circle:
            var coverArea = new Ellipse()
            {
                Name = "coverArea4",
                Width = 120,
                Height = 120,
                Fill = new SolidColorBrush(Color.FromArgb(40, 0, 0, 255)),
                Stroke = new SolidColorBrush(Color.FromArgb(65, 0, 0, 0))
            };

            Map.Children.Add(coverArea);
            Canvas.SetLeft(coverArea, Canvas.GetLeft(TowerPlacement4) - TowerPlacement4.Width);
            Canvas.SetTop(coverArea, Canvas.GetTop(TowerPlacement4) - TowerPlacement4.Height);
        }
        #endregion

        #endregion

        private void Mob1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    //Canvas.SetLeft(Mob1, 224);
                    Canvas.SetLeft(Mob1, Canvas.GetLeft(Mob1) - 4);
                    break;
                case Key.Right:
                    //Canvas.SetLeft(Mob1, 264);
                    Canvas.SetLeft(Mob1, Canvas.GetLeft(Mob1) + 4);
                    break;
            }
        }

        private void CoverShow(object sender, RoutedEvent e)
        {

        }
    }
}
