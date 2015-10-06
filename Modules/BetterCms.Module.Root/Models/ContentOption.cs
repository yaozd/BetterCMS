using System;
using System.Collections.Generic;
using System.Linq;

using BetterCms.Core;
using BetterCms.Core.DataContracts;
using BetterCms.Core.DataContracts.Enums;

using BetterModules.Core.Models;

namespace BetterCms.Module.Root.Models
{
    [Serializable]
    public class ContentOption : EquatableEntity<ContentOption>, IDeletableOption<Content>, IMultilangualOption
    {
        public ContentOption()
        {
            Translations = new List<ContentOptionTranslation>();
            IsDeletable = true;
        }

        public virtual Content Content { get; set; }

        public virtual string Key { get; set; }

        public virtual OptionType Type { get; set; }

        public virtual string DefaultValue { get; set; }

        public virtual bool IsDeletable { get; set; }

        public virtual CustomOption CustomOption { get; set; }

        public virtual IList<ContentOptionTranslation> Translations { get; set; }

        IList<IOptionTranslation> IMultilangualOption.Translations
        {
            get
            {
                return Translations.Cast<IOptionTranslation>().ToList();
            }
            set
            {
                Translations = value.Cast<ContentOptionTranslation>().ToList();
            }
        }

        string IOption.Value
        {
            get
            {
                return DefaultValue;
            }
            set
            {
                DefaultValue = value;
            }
        }

        Content IDeletableOption<Content>.Entity
        {
            get
            {
                return Content;
            }
            set
            {
                Content = value;
            }
        }

        ICustomOption IOption.CustomOption
        {
            get
            {
                return CustomOption;
            }
            set
            {
                CustomOption = (CustomOption)value;
            }
        }

        public virtual ContentOption Clone()
        {
            return CopyDataTo(new ContentOption());
        }

        public virtual ContentOption CopyDataTo(ContentOption contentOption)
        {
            contentOption.Key = Key;
            contentOption.Type = Type;
            contentOption.DefaultValue = DefaultValue;
            contentOption.IsDeletable = IsDeletable;
            contentOption.Content = Content;

            return contentOption;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}, Key: {1}, DefaultValue: {2}, Type: {3}", base.ToString(), Key, DefaultValue, Type);
        }
    }
}