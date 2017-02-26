using STA.SuperCompra.UI.Mvc.Infraestrutura.Helpers.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace STA.SuperCompra.UI.Mvc.Infraestrutura.Helpers
{
    public class CustomHelpers
    {
        private HtmlHelper helper;

        public CustomHelpers(HtmlHelper helperParam)
        {
            helper = helperParam;
        }

        public IHtmlString TextBox(string id, TextBoxType type = TextBoxType.Texto, bool exibirMsgValidacao = true, object htmlAttributes = null)
        {
            var attributes = new RouteValueDictionary(htmlAttributes);
            var labelBuilder = new TagBuilder("label");
            labelBuilder.AddCssClass("input");

            switch (type)
            {
                case TextBoxType.Nome:
                    var iconBuilderNome = new TagBuilder("i");
                    iconBuilderNome.MergeAttribute("class", "icon-prepend fa fa-user");
                    labelBuilder.InnerHtml += iconBuilderNome;
                    break;
                case TextBoxType.Email:
                    var iconBuilderEmail = new TagBuilder("i");
                    iconBuilderEmail.MergeAttribute("class", "icon-prepend fa fa-envelope-o");
                    labelBuilder.InnerHtml += iconBuilderEmail;
                    break;
                case TextBoxType.Telefone:
                    var iconBuilderTelefone = new TagBuilder("i");
                    iconBuilderTelefone.MergeAttribute("class", "icon-prepend fa fa-phone");
                    attributes.Add("data-mask", "(99)9999-9999");
                    labelBuilder.InnerHtml += iconBuilderTelefone;
                    break;
                case TextBoxType.Cep:
                    attributes.Add("data-mask", "99.999-999");
                    break;
                case TextBoxType.Senha:
                    var iconBuilderSenha = new TagBuilder("i");
                    iconBuilderSenha.MergeAttribute("class", "icon-prepend fa fa-lock");
                    attributes.Add("type", "password");
                    labelBuilder.InnerHtml += iconBuilderSenha;
                    break;
                case TextBoxType.Data:
                    var iconBuilderData = new TagBuilder("i");
                    iconBuilderData.MergeAttribute("class", "icon-append fa fa-calendar");
                    labelBuilder.InnerHtml += iconBuilderData;
                    attributes.Add("class", "datepicker");
                    attributes.Add("data-dateformat", "dd/mm/yy");
                    attributes.Add("data-mask", "99/99/9999");
                    break;
            }

            var textBoxHelper = helper.TextBox(id, helper.Value(id).ToHtmlString(), attributes);
            labelBuilder.InnerHtml += textBoxHelper;


            var tagMsgValidation = string.Empty;

            if (!helper.ViewData.ModelState.IsValidField(id))
            {
                labelBuilder.AddCssClass("state-error");

                if (exibirMsgValidacao)
                {
                    var validationBuilder = helper.ValidationMessage(id).ToString().Replace("span", "em");
                    tagMsgValidation += validationBuilder.ToString();
                }

            }

            var htmlRetorno = labelBuilder + tagMsgValidation;

            return MvcHtmlString.Create(htmlRetorno);
        }

        public IHtmlString ImageActionLink(string sIcon, string linkName, string actionName, string controllerName,
            object routeValues, object htmlAttributes = null)
        {
            var attributes = new RouteValueDictionary(htmlAttributes);
            var iconBuilder = new TagBuilder("i");
            iconBuilder.MergeAttribute("class", sIcon);
            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext, helper.RouteCollection);
            var linkBuilder = new TagBuilder("a");
            var href = "#" + urlHelper.Action(actionName, controllerName, routeValues);

            if (attributes.ContainsKey("onclick"))
                href = "javascript:void(0)";

            linkBuilder.MergeAttribute("href", href);
            linkBuilder.InnerHtml += iconBuilder;
            linkBuilder.InnerHtml += linkName;
            linkBuilder.MergeAttributes(attributes, true);
            return MvcHtmlString.Create(linkBuilder.ToString());

        }

        public IHtmlString DropDownList(string id, IEnumerable<SelectListItem> selectList,
            bool exibirMsgValidation = true,
            string optionLabel = null, object htmlAttributes = null)
        {
            var labelBuilder = new TagBuilder("label");
            labelBuilder.MergeAttribute("class", "select");

            var dropDownListHelper = helper.DropDownList(id, selectList, optionLabel, htmlAttributes);
            var iconArrow = new TagBuilder("i");
            labelBuilder.InnerHtml += dropDownListHelper + iconArrow.ToString();

            var tagMsgValidation = string.Empty;

            if (!helper.ViewData.ModelState.IsValidField(id))
            {
                labelBuilder.AddCssClass("state-error");

                if (exibirMsgValidation)
                {
                    var validationBuilder = helper.ValidationMessage(id).ToString().Replace("span", "em");
                    tagMsgValidation += validationBuilder.ToString();
                }
            }

            var htmlRetorno = labelBuilder + tagMsgValidation;

            return MvcHtmlString.Create(htmlRetorno);
        }
    }
}