namespace PrototypePattern
{
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }

        protected MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public abstract MonkeyKingPrototype Clone();
    }
}
