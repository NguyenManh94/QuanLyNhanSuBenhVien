using DevExpress.XtraEditors.Controls;

namespace QlNhanSuBenhVien.UserInterface
{
    class ThongBaoViet : Localizer
    {
        public string Abort { set; get; }
        public string Cancel { set; get; }
        public string Ignore { set; get; }
        public string No { set; get; }
        public string Ok { set; get; }
        public string Retry { set; get; }
        public string Yes { set; get; }

        public ThongBaoViet(string abort, string cancel, string ignore, string no, string ok, string retry, string yes)
        {
            this.Abort = abort;
            this.Cancel = cancel;
            this.Ignore = ignore;
            this.No = no;
            this.Ok = ok;
            this.Retry = retry;
            this.Yes = yes;
        }

        public override string GetLocalizedString(StringId id)
        {
            if (id == StringId.XtraMessageBoxAbortButtonText) return Abort;
            if (id == StringId.XtraMessageBoxCancelButtonText) return Cancel;
            if (id == StringId.XtraMessageBoxIgnoreButtonText) return Ignore;
            if (id == StringId.XtraMessageBoxNoButtonText) return No;
            if (id == StringId.XtraMessageBoxOkButtonText) return Ok;
            if (id == StringId.XtraMessageBoxRetryButtonText) return Retry;
            if (id == StringId.XtraMessageBoxYesButtonText) return Yes;
            return base.GetLocalizedString(id);
        }
    }
}
