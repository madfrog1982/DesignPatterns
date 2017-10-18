namespace CompositePattern.Safety
{
    /// <summary>
    /// 图形抽象类
    /// </summary>
    public abstract class Graphics
    {
        public string Name { get; set; }

        protected Graphics(string name)
        {
            this.Name = name;
        }

        public abstract void Draw();
    }
}
