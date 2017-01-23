﻿using Implem.Pleasanter.Interfaces;
namespace Implem.Pleasanter.Libraries.Settings
{
    public class FormulaSet : ISettingListItem
    {
        public int Id { get; set; }
        public string Target;
        public int? Condition;
        public Formula Formula;
        public Formula OutOfCondition;
    }
}