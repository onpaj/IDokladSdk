﻿using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.CreditNote;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public class CreditNoteClient : BaseClient
    {
        internal const string ResourceUrl = "/CreditNotes";

        public CreditNoteClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// PUT api/CreditNotes/{id}/FullyPay?dateOfPayment={dateOfPayment}
        /// Method sets credit note as paid.
        /// </summary>
        public bool FullyPay(int creditNoteId, DateTime paid)
        {
            return base.Put<bool>(ResourceUrl + "/" + creditNoteId + "/FullyPay" + "?dateOfPayment=" + paid.ToString(DateFormat));
        }

        /// <summary>
        /// PUT api/CreditNotes/{id}/FullyUnpay
        /// Method sets credit note as unpaid.
        /// </summary>
        /// <returns></returns>
        public bool FullyUnpay(int creditNoteId)
        {
            return base.Put<bool>(ResourceUrl + "/" + creditNoteId + "/FullyUnpay");
        }

        /// <summary>
        /// GET api/CreditNotes/Expand
        /// Returns credit note list with related entities such as contact information etc.
        /// </summary>
        public RowsResultWrapper<CreditNoteExpand> CreditNotesExpand(CreditNoteFilter filter = null)
        {
            return base.Get<RowsResultWrapper<CreditNoteExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/CreditNotes/{id}/Expand
        /// Returns Credit note with related entities by Id.
        /// </summary>
        public CreditNoteExpand CreditNoteExpand(int creditNoteId)
        {
            return base.Get<CreditNoteExpand>(ResourceUrl + "/" + creditNoteId +  "/Expand");
        }

        /// <summary>
        /// PUT api/CreditNotes/{id}/Exported/{value}
        /// Method updates Exported property of the invoice.
        /// </summary>
        public bool ChangeExported(int creditNoteId, ExportedStateEnum state)
        {
            return base.Put<bool>(ResourceUrl + "/" + creditNoteId + "/Exported" + "/" + (int)state);
        }

        /// <summary>
        /// GET api/CreditNotes
        /// Returns list of credit notes. Filters are optional.
        /// </summary>
        public RowsResultWrapper<CreditNote> CreditNotes(CreditNoteFilter filter = null)
        {
            return base.Get<RowsResultWrapper<CreditNote>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/CreditNotes/{id}
        /// Returns information about credit note including summaries.
        /// </summary>
        public CreditNote CreditNotes(int creditNoteId)
        {
            return base.Get<CreditNote>(ResourceUrl + "/" + creditNoteId);
        }
    }
}