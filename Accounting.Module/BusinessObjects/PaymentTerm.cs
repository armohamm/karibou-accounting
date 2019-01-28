﻿using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System.ComponentModel;

namespace Accounting.Module.BusinessObjects
{
    [Appearance("New", "Not IsNewObject(This)", TargetItems = "*;Name", Enabled = false)]
    [DefaultProperty("Name")]
    [ImageName("BO_Task")]
    [RuleCriteria("PaymentTerm_Customer_RuleCriteria", DefaultContexts.Delete, "[<Customer>][PaymentTerm = ^.Oid].Count() = 0", "Payment terms that are referenced by customers cannot be deleted. Update the customer first, and then delete the payment term.")]
    [RuleCriteria("PaymentTerm_Invoice_RuleCriteria", DefaultContexts.Delete, "[<Invoice>][PaymentTerm = ^.Oid].Count() = 0", "Payment terms that are referenced by invoices cannot be deleted. Update the invoices first, and then delete the payment term.")]
    [RuleCriteria("PaymentTerm_Supplier_RuleCriteria", DefaultContexts.Delete, "[<Supplier>][PaymentTerm = ^.Oid].Count() = 0", "Payment terms that are referenced by suppliers cannot be deleted. Update the suppliers first, and then delete the payment term.")]
    public class PaymentTerm : BaseObject
    {
        public PaymentTerm(Session session) : base(session)
        {
        }

        [RuleRequiredField("PaymentTerm_Name_RuleRequiredField", DefaultContexts.Save)]
        [RuleUniqueValue("PaymentTerm_Name_RuleUniqueValue", DefaultContexts.Save)]
        public string Name
        {
            get => GetPropertyValue<string>(nameof(Name));
            set => SetPropertyValue(nameof(Name), value);
        }

        [VisibleInLookupListView(true)]
        public int Term
        {
            get => GetPropertyValue<int>(nameof(Term));
            set => SetPropertyValue(nameof(Term), value);
        }
    }
}