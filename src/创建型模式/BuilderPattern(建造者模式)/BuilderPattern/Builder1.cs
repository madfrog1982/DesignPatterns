namespace BuilderPattern
{
    /// <summary NoteObject="class">
    /// [功能描述:建造者1]
    /// [设计创建者:madfrog]
    /// [设计创建时间:2017-10-16]
    /// [编码创建者:madfrog]
    /// [编码创建时间:2017-10-16]
    /// <说明>
    ///     [内容:]
    /// </说明>
    /// <修改记录>
    ///     [修改者:]
    ///     [修改时间:]
    ///     [修改内容:]
    /// </修改记录>
    /// </summary>
    public class Builder1 : Builder
    {
        private readonly Computer _computer = new Computer();

        public override void BuildPartCPU()
        {
            _computer.Add("CPU1");
        }

        public override void BuildPartMainBoard()
        {
            _computer.Add("Main board1");
        }

        public override Computer GetComputer()
        {
            return _computer;
        }
    }
}
