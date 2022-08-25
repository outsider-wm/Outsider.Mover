using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outsider.Mover
{
    public struct Transform
    {
        private int _x;
        private int _y;
        private int _height;
        private int _width;

        public Transform(int x, int y, int height, int width)
        {
            _x = x; _y = y; _height = height; _width = width;
        }

        public override string ToString()
        {
            return $"X: {_x}, Y: {_y}, Height: {_height}, Width: {_width}";
        }
    }
    public class Tile
    {
        private Wrapper.Window _window;
        private Transform _transform;
        private TileMode _mode;



        public Tile(Wrapper.Window window, Transform? transform = null, TileMode tileMode = TileMode.Tiling)
        {
            _window = window;
            _transform = (Transform)(transform is null ? new Transform(window.WindowInfo.rcWindow.X,
                                                           window.WindowInfo.rcWindow.Y,
                                                           window.WindowInfo.rcWindow.Height,
                                                           window.WindowInfo.rcWindow.Width) : transform);
            _mode = tileMode;
        }

        public override string ToString()
        {
            return _transform.ToString();
        }

        public IntPtr GetMonitorHandle()
        {
            return _window.MonitorHandle;
        }

        public IntPtr GetWindowHandle()
        {
            return _window.Handle;
        }
    }
}
