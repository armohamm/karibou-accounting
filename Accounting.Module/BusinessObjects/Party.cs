﻿using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System.ComponentModel;

namespace Accounting.Module.BusinessObjects
{
    [DefaultProperty("Name")]
    [ModelDefault("DefaultLookupEditorMode", "AllItems")]
    public abstract class Party : BaseObject
    {
        protected Party(Session session) : base(session)
        {
        }

        public string AccountNumber
        {
            get => GetPropertyValue<string>(nameof(AccountNumber));
            set => SetPropertyValue(nameof(AccountNumber), value);
        }

        public string Address
        {
            get => GetPropertyValue<string>(nameof(Address));
            set => SetPropertyValue(nameof(Address), value);
        }

        public string City
        {
            get => GetPropertyValue<string>(nameof(City));
            set => SetPropertyValue(nameof(City), value);
        }

        public string Contact
        {
            get => GetPropertyValue<string>(nameof(Contact));
            set => SetPropertyValue(nameof(Contact), value);
        }

        [ModelDefault("AllowClear", "False")]
        [RuleRequiredField("Party_Country_RuleRequiredField", DefaultContexts.Save)]
        public Country Country
        {
            get => GetPropertyValue<Country>(nameof(Country));
            set => SetPropertyValue(nameof(Country), value);
        }

        [RuleRegularExpression("Party_Email_RuleRegularExpression", DefaultContexts.Save, @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-||_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+([a-z]+|\d|-|\.{0,1}|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])?([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))$")]
        public string Email
        {
            get => GetPropertyValue<string>(nameof(Email));
            set => SetPropertyValue(nameof(Email), value);
        }

        [ModelDefault("Caption", "VAT Included")]
        [ModelDefault("CaptionForFalse", "No")]
        [ModelDefault("CaptionForTrue", "Yes")]
        public bool IsVatIncluded
        {
            get => GetPropertyValue<bool>(nameof(IsVatIncluded));
            set => SetPropertyValue(nameof(IsVatIncluded), value);
        }

        public string LegalEntityIdentifier
        {
            get => GetPropertyValue<string>(nameof(LegalEntityIdentifier));
            set => SetPropertyValue(nameof(LegalEntityIdentifier), value);
        }

        [ImmediatePostData]
        [RuleRequiredField("Party_Name_RuleRequiredField", DefaultContexts.Save)]
        public string Name
        {
            get => GetPropertyValue<string>(nameof(Name));
            set => SetPropertyValue(nameof(Name), value);
        }

        [ModelDefault("AllowClear", "False")]
        public PaymentTerm PaymentTerm
        {
            get => GetPropertyValue<PaymentTerm>(nameof(PaymentTerm));
            set => SetPropertyValue(nameof(PaymentTerm), value);
        }

        public string Phone
        {
            get => GetPropertyValue<string>(nameof(Phone));
            set => SetPropertyValue(nameof(Phone), value);
        }

        public string PostalCode
        {
            get => GetPropertyValue<string>(nameof(PostalCode));
            set => SetPropertyValue(nameof(PostalCode), value);
        }

        public string VatIdentifier
        {
            get => GetPropertyValue<string>(nameof(VatIdentifier));
            set => SetPropertyValue(nameof(VatIdentifier), value);
        }

        public string Website
        {
            get => GetPropertyValue<string>(nameof(Website));
            set => SetPropertyValue(nameof(Website), value);
        }
    }
}