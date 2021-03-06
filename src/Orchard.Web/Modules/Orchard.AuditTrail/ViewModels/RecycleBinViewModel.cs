using System.Collections.Generic;
using Orchard.Collections;
using Orchard.ContentManagement;

namespace Orchard.AuditTrail.ViewModels {
    public class RecycleBinViewModel {
        public RecycleBinViewModel() {
            SelectedContentItems = new List<RemovedContentItemViewModel>(0);
        }
        public RecycleBinBulkAction? RecycleBinBulkAction { get; set; }
        public IList<RemovedContentItemViewModel> SelectedContentItems { get; set; }
        public AdminIndexOptions Options { get; set; }
        public IPageOfItems<ContentItem> ContentItems { get; set; }
        public dynamic Pager { get; set; }
    }

    public class AdminIndexOptions {
        public RecycleBinBulkAction BulkAction { get; set; }
    }
}