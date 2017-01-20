using System;

namespace LolGuide
{
    internal class MasterPageItem
    {
        public string IconSource { get; internal set; }
        public Type TargetType { get; internal set; }
        public string Title { get; internal set; }
    }
}