using Microsoft.AspNetCore.Razor.TagHelpers;

namespace OrchardCore.DisplayManagement.TagHelpers
{
    [HtmlTargetElement("shape", Attributes = nameof(Type))]
    public class ShapeTagHelper : BaseShapeTagHelper
    {
        public ShapeTagHelper(IShapeFactory shapeFactory, IDisplayHelper displayHelper)
			:base(shapeFactory, displayHelper)
        {
            _shapeFactory = shapeFactory;
            _displayHelper = displayHelper;
        }
    }
}