using System.Collections.Generic;

namespace CompositePattern.Transparent
{
    public class ComplexGraphics : Graphics
    {
        private readonly List<Graphics> _complexGraphicsList = new List<Graphics>();

        public ComplexGraphics(string name) : base(name) { }

        /// <summary>
        /// 复杂图形画法
        /// </summary>
        public override void Draw()
        {
            foreach (Graphics g in _complexGraphicsList)
            {
                g.Draw();
            }
        }

        public override void Add(Graphics g)
        {
            _complexGraphicsList.Add(g);
        }

        public override void Remove(Graphics g)
        {
            _complexGraphicsList.Remove(g);
        }
    }
}
