namespace CodeImp.DoomBuilder.SRB2
{
    public struct SRB2State
    {
        #region ================== Variables

        private string name;
        private string spritename;
        private int spriteframe;
        private string next;

        public SRB2State(string name, string spritename, int spriteframe, string next)
        {
            this.name = name;
            this.spritename = spritename;
            this.spriteframe = spriteframe;
            this.next = next;
        }

        #endregion
    }
}