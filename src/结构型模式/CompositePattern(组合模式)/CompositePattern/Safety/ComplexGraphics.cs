using System.Collections.Generic;

namespace CompositePattern.Safety
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

        public void Add(Graphics g)
        {
            _complexGraphicsList.Add(g);
        }

        public void Remove(Graphics g)
        {
            _complexGraphicsList.Remove(g);
        }
    }
}
