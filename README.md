# child_item_in_dynamic_widget_view
How to access the child items in dynamic widget views

1) Refer to Module Builder  > Your module > Code references > Get child items of a Parent
2) Ensure the necessary namespace usings are present:
@using Telerik.Sitefinity.Frontend.Mvc.Helpers;
@using Telerik.Sitefinity.Frontend.DynamicContent.Mvc.Helpers;
@using Telerik.Sitefinity.Utilities.TypeConverters;
@using Telerik.Sitefinity.DynamicModules.Builder.Web.UI;

3) TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.CustomContent.ChildContentTypeName");
