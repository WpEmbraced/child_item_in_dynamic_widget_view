@using Telerik.Sitefinity.DynamicModules.Builder.Web.UI;
@using Telerik.Sitefinity.Utilities.TypeConverters;
@using Telerik.Sitefinity.Frontend.DynamicContent.Mvc.Helpers;

@{
  var typeName = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.CustomContent.InterestGroupNews").Name;
  var pluralTypeName = PluralsResolver.Instance.ToPlural(typeName);
}
@foreach (var childItem in Model.Item.ChildItems(pluralTypeName))
{
  @childItem.Fields.Title;
}
