﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 1 "..\..\Views\Shared\ItemList.cshtml"
    using Frapid.ApplicationState.Cache;
    
    #line default
    #line hidden
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    using MixERP.Purchases;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ItemList.cshtml")]
    public partial class _Views_Shared_ItemList_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_ItemList_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\ItemList.cshtml"
  
    ViewBag.Title = "Purchase";
    Layout = ViewBag.PurchaseLayoutPath;
    var meta = AppUsers.GetCurrent();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"/Areas/MixERP.Purchases/Styles/purchase.css\"");

WriteLiteral("></link>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"SalesTaxRateHidden\"");

WriteLiteral(" />\r\n\r\n<div");

WriteLiteral(" class=\"ui attached inverted pos purchase segment\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui active inverted dimmer\"");

WriteLiteral(" id=\"POSDimmer\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui large text loader\"");

WriteLiteral(">Loading items ...</div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"ui grid\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"eleven wide column\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"status head\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"left\"");

WriteLiteral(">\r\n                    <strong");

WriteLiteral(" class=\"title info\"");

WriteLiteral(">\r\n                        Purchase\r\n                    </strong>\r\n             " +
"       <span");

WriteLiteral(" class=\"office info\"");

WriteLiteral(" title=\"Current Branch Office\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 25 "..\..\Views\Shared\ItemList.cshtml"
                   Write(meta.OfficeName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"user info\"");

WriteLiteral(" title=\"You\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 28 "..\..\Views\Shared\ItemList.cshtml"
                   Write(meta.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"area info\"");

WriteLiteral(" title=\"Current Area\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 31 "..\..\Views\Shared\ItemList.cshtml"
                   Write(meta.OfficeCode);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                    <span");

WriteLiteral(" class=\"office info\"");

WriteLiteral(" title=\"Office Name\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 34 "..\..\Views\Shared\ItemList.cshtml"
                   Write(meta.OfficeName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </span>\r\n                </div>\r\n\r\n                <div");

WriteLiteral(" class=\"right\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"inline blocks\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"item\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" class=\"ui search inverted fluid dropdown\"");

WriteLiteral(" id=\"PriceTypeSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"       </div>\r\n\r\n            </div>\r\n\r\n\r\n\r\n            <div");

WriteLiteral(" class=\"category list\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"cat filter\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                    Clear\r\n                    <i");

WriteLiteral(" class=\"delete icon\"");

WriteLiteral("></i>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"search panel\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" type=\"search\"");

WriteLiteral(" placeholder=\"Search ...\"");

WriteLiteral("/>\r\n\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"item list\"");

WriteLiteral(" id=\"POSItemList\"");

WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"five wide column\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" id=\"PurchaseItems\"");

WriteLiteral(" class=\"purchase items\"");

WriteLiteral(">\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"tender info\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"page title\"");

WriteLiteral(">Purchase</div>\r\n                <div");

WriteLiteral(" id=\"SummaryItems\"");

WriteLiteral(" class=\"two summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"amount item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Amount</div>\r\n                        <div");

WriteLiteral(" class=\"money\"");

WriteLiteral(">\r\n                            <span></span>\r\n                        </div>\r\n   " +
"                 </div>\r\n                    <div");

WriteLiteral(" class=\"store item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Store</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" id=\"StoreSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"       </div>\r\n                <div");

WriteLiteral(" class=\"one summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"supplier item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Supplier</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" id=\"SupplierSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"       </div>\r\n                <div");

WriteLiteral(" class=\"two summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"value date item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Value Date</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" id=\"ValueDateInputDate\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"    <div");

WriteLiteral(" class=\"book date item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Book Date</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" id=\"BookDateInputDate\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"two summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"cost center item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Cost Center</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" id=\"CostCenterSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"           <div");

WriteLiteral(" class=\"shipping company item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Shipper</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <select");

WriteLiteral(" id=\"ShipperSelect\"");

WriteLiteral("></select>\r\n                        </div>\r\n                    </div>\r\n         " +
"       </div>\r\n                <div");

WriteLiteral(" class=\"two summary items\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"reference number item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Ref#</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"ReferenceNumberInputText\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"    <div");

WriteLiteral(" class=\"memo item\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"description\"");

WriteLiteral(">Memo</div>\r\n                        <div");

WriteLiteral(" class=\"control\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"StatementReferenceInputText\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"</div>\r\n                <div");

WriteLiteral(" class=\"ui one column padded grid\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"column\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" id=\"CheckoutButton\"");

WriteLiteral(" class=\"ui green icon button\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"cart icon\"");

WriteLiteral("></i>\r\n                            CHECKOUT\r\n                        </button>\r\n " +
"                       <button");

WriteLiteral(" id=\"ClearScreenButton\"");

WriteLiteral(" class=\"ui red icon button\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"delete icon\"");

WriteLiteral("></i>\r\n                            CLS\r\n                        </button>\r\n      " +
"              </div>\r\n                </div>\r\n            </div>\r\n        </div>" +
"\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    $(\"#PurchaseItems .item\")\r\n        .on(\"co" +
"ntextmenu\",\r\n            function (e) {\r\n                e.preventDefault();\r\n  " +
"              const el = $(this);\r\n                const defaultMenu = el.find(\"" +
".info.block, .number.block\");\r\n                const contextMenu = el.find(\".con" +
"text.menu\");\r\n\r\n                defaultMenu.toggle();\r\n                contextMe" +
"nu.toggle();\r\n            });\r\n</script>\r\n\r\n<script>\r\n    var itemTemplate = `<d" +
"iv class=\"item\" id=\"pos-{ItemId}\" data-cost-price=\"{CostPrice}\" data-photo=\"{Pho" +
"to}\" data-unit-id=\"{UnitId}\" data-valid-units=\"{ValidUnits}\" data-brand=\"{BrandN" +
"ame}\" data-item-group=\"{ItemGroupName}\" data-item-name=\"{ItemName}\" data-item-co" +
"de=\"{ItemCode}\" data-item-id=\"{ItemId}\" data-price=\"{Price}\">\r\n\t<div class=\"phot" +
"o block\">\r\n\t\t<img src=\"{Photo}\">\r\n\t</div>\r\n\t<div class=\"info block\">\r\n\t\t<div cla" +
"ss=\"header\">{ItemName}</div>\r\n\t\t<div class=\"price info\">\r\n\t\t\t<span class=\"rate\">" +
"{CostPrice}</span>\r\n\t\t\t<span>&nbsp; x&nbsp; </span>\r\n\t\t\t<span class=\"quantity\">1" +
"</span>\r\n\t\t\t<span>&nbsp; =&nbsp; </span>\r\n\t\t\t<span class=\"amount\"></span>\r\n\t\t</d" +
"iv>\r\n\t\t<div class=\"discount info\" style=\"display:none;\">\r\n\t\t\t<span>Less&nbsp; </" +
"span>\r\n\t\t\t<span class=\"discount rate\"></span>\r\n\t\t\t<span>&nbsp; =&nbsp; </span>\r\n" +
"\t\t\t<span class=\"discounted amount\"></span>\r\n\t\t</div>\r\n\t\t<div class =\"tax info\" s" +
"tyle=\"display:none;\">\r\n\t\t\t<span>Add Tax </span>\r\n\t\t\t<span class =\"tax-amount\"></" +
"span>\r\n\t\t\t<span> (</span>\r\n\t\t\t<span class =\"tax-rate\"></span>\r\n\t\t\t<span>%) = </s" +
"pan>\r\n\t\t\t<span class =\"amount-plus-tax\"></span>\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<select c" +
"lass=\"unit inverted\" data-item-id=\"{ItemId}\">\r\n\t\t\t</select>\r\n\t\t</div>\r\n\t</div>\r\n" +
"\t<div class=\"number block\">\r\n\t\t<input type=\"text\" class=\"price\" title=\"Edit Pric" +
"e\" value=\"{CostPrice}\">\r\n\t\t<input type=\"text\" class=\"quantity\" title=\"Enter Quan" +
"tity\" value=\"1\">\r\n\t\t<input type=\"text\" class=\"discount\" title=\"Enter Discount\" v" +
"alue=\"\">\r\n\t\t<button class=\"ui red fluid button\" onclick=\"removeItem(this);\" styl" +
"e=\"display:none;\">Delete</button>\r\n\t</div>\r\n</div>`\r\n</script>\r\n\r\n<script>\r\n    " +
"var products = [];\r\n    var metaUnits = [];\r\n\r\n    function fetchUnits() {\r\n    " +
"    function request() {\r\n            const url = \"/api/forms/inventory/units/al" +
"l\";\r\n            return window.getAjaxRequest(url);\r\n        };\r\n\r\n        const" +
" ajax = request();\r\n\r\n        ajax.success(function (response) {\r\n            wi" +
"ndow.metaUnits = response;\r\n        });\r\n    };\r\n\r\n    function fetchProducts() " +
"{\r\n        function request() {\r\n            const url = \"/dashboard/purchase/ta" +
"sks/items\";\r\n            return window.getAjaxRequest(url);\r\n        };\r\n\r\n     " +
"   const ajax = request();\r\n\r\n        ajax.success(function (response) {\r\n      " +
"      window.products = response;\r\n            $(document).trigger(\"itemFetched\"" +
");\r\n        });\r\n    };\r\n\r\n    $(\".search.panel input\").keyup(function () {\r\n   " +
"     const el = $(this);\r\n        const term = el.val();\r\n\r\n        const catego" +
"ryEl = $(\".category.list .selected.category\");\r\n        var category = \"\";\r\n\r\n  " +
"      if (categoryEl.length) {\r\n            category = categoryEl.text();\r\n     " +
"   };\r\n\r\n        displayProducts(category, term);\r\n\r\n        initializeClickAndA" +
"ction();\r\n    });\r\n\r\n    $(\".search.panel input\").keydown(function (e) {\r\n      " +
"  if (e.keyCode === 13) {\r\n            const item = $(\".item.list .item:first\");" +
"\r\n\r\n            if (item.length) {\r\n                item.trigger(\"click\");\r\n    " +
"        };\r\n        };\r\n    });\r\n\r\n    window.fetchUnits();\r\n    window.fetchPro" +
"ducts();\r\n\r\n    setTimeout(function () {\r\n        window.fetchProducts();\r\n    }" +
", 120000);\r\n\r\n    function removeItem(el) {\r\n        const confirmed = confirm(\"" +
"Are you sure?\");\r\n\r\n        if (!confirmed) {\r\n            return;\r\n        };\r\n" +
"\r\n        el = $(el);\r\n        const container = el.parent().parent();\r\n        " +
"container.remove();\r\n        window.updateTotal();\r\n    };\r\n\r\n    $(document).on" +
"(\"itemFetched\", function () {\r\n        $(\"#POSDimmer\").removeClass(\"active\");\r\n " +
"       displayProducts();\r\n        displayCategories();\r\n        initializeClick" +
"AndAction();\r\n    });\r\n\r\n\r\n    function initializeClickAndAction() {\r\n        $(" +
"\"#POSItemList .item\").unbind(\"click\").bind(\"click\", function () {\r\n            v" +
"ar el = $(this);\r\n            var costPrice = el.attr(\"data-cost-price\");\r\n     " +
"       var photo = el.attr(\"data-photo\");\r\n\r\n            var barCode = el.attr(\"" +
"data-barcode\");\r\n            var brand = el.attr(\"data-brand\");\r\n            var" +
" unitId = el.attr(\"data-unit-id\");\r\n            var validUnits = el.attr(\"data-v" +
"alid-units\");\r\n            var itemGroup = el.attr(\"data-item-group\");\r\n        " +
"    var itemName = el.attr(\"data-item-name\");\r\n            var itemCode = el.att" +
"r(\"data-item-code\");\r\n            var itemId = el.attr(\"data-item-id\");\r\n       " +
"     var price = parseFloat(costPrice || 0);\r\n            var isTaxableItem = el" +
".attr(\"data-is-taxable-item\") === \"true\";\r\n            var taxRate = window.pars" +
"eFloat($(\"#SalesTaxRateHidden\").val());\r\n\r\n            if (!price) {\r\n          " +
"      alert(\"Cannot add item because the price is zero.\");\r\n                retu" +
"rn;\r\n            };\r\n\r\n\r\n\r\n            var targetEl = $(\"#PurchaseItems\");\r\n    " +
"        var selector = \"pos-\" + itemId;\r\n            var existingEl = $(\"#\" + se" +
"lector);\r\n\r\n            if (existingEl.length) {\r\n                var existingQu" +
"antitySpan = existingEl.find(\"span.quantity\");\r\n                var existingQuan" +
"tityInput = existingEl.find(\"input.quantity\");\r\n\r\n                var quantity =" +
" parseInt(existingQuantitySpan.text() || 0);\r\n                quantity++;\r\n\r\n   " +
"             existingQuantitySpan.text(quantity);\r\n                existingQuant" +
"ityInput.val(quantity).trigger(\"keyup\");\r\n\r\n                window.updateTotal()" +
";\r\n                return;\r\n            };\r\n\r\n            var template = itemTem" +
"plate;\r\n\r\n            template = template.replace(/{ItemId}/g, itemId);\r\n       " +
"     template = template.replace(/{CostPrice}/g, costPrice);\r\n            templa" +
"te = template.replace(/{Photo}/g, photo);\r\n            template = template.repla" +
"ce(/{BarCode}/g, barCode);\r\n            template = template.replace(/{BrandName}" +
"/g, brand);\r\n            template = template.replace(/{ItemGroupName}/g, itemGro" +
"up);\r\n            template = template.replace(/{ItemName}/g, itemName);\r\n       " +
"     template = template.replace(/{ItemCode}/g, itemCode);\r\n            template" +
" = template.replace(/{Price}/g, price);\r\n            template = template.replace" +
"(/{UnitId}/g, unitId);\r\n            template = template.replace(/{ValidUnits}/g," +
" validUnits);\r\n\r\n            var item = $(template);\r\n            var quantityIn" +
"put = item.find(\"input.quantity\");\r\n            var priceInput = item.find(\"inpu" +
"t.price\");\r\n            var discountInput = item.find(\"input.discount\");\r\n      " +
"      var unitSelect = item.find(\"select.unit\");\r\n\r\n            function loadUni" +
"ts(el, defaultUnitId, validUnits) {\r\n                el.html(\"\");\r\n\r\n           " +
"     const units = window.Enumerable.From(window.metaUnits)\r\n                   " +
" .Where(function (x) {\r\n                        return validUnits.indexOf(x.Unit" +
"Id.toString()) > -1;\r\n                    }).ToArray();\r\n\r\n                $.eac" +
"h(units, function () {\r\n                    const unit = this;\r\n\r\n              " +
"      const option = $(\"<option/ >\");\r\n                    option.attr(\"value\", " +
"unit.UnitId);\r\n                    option.html(unit.UnitName);\r\n\r\n              " +
"      if (defaultUnitId === unit.UnitId) {\r\n                        option.attr(" +
"\"selected\", \"\");\r\n                    };\r\n\r\n                    option.appendTo(" +
"el);\r\n                });\r\n\r\n            };\r\n\r\n            loadUnits(unitSelect," +
" unitId, validUnits.split(\',\'));\r\n\r\n            function updateItemTotal(el) {\r\n" +
"                const quantityEl = el.find(\"input.quantity\");\r\n                c" +
"onst discountEl = el.find(\"input.discount\");\r\n\r\n                const quantity =" +
" parseInt(quantityEl.val() || 0);\r\n                const discountRate = parseFlo" +
"at(discountEl.val().replace(\"%\", \"\"));\r\n                const price = parseFloat" +
"(el.find(\"input.price\").val());\r\n\r\n                const amount = window.round(p" +
"rice * quantity, 2);\r\n                const discountedAmount = window.round((pri" +
"ce * quantity) * ((100 - discountRate) / 100), 2);\r\n\r\n                el.find(\"s" +
"pan.rate:not(.discount)\").html(price);\r\n                el.find(\"span.quantity\")" +
".html(quantity);\r\n                el.find(\"span.amount\").html(amount);\r\n        " +
"        el.find(\"span.discount.rate\").html(\"\");\r\n                el.find(\"span.d" +
"iscounted.amount\").html(\"\");\r\n\r\n                if (discountRate) {\r\n           " +
"         el.find(\".discount.info\").show();\r\n                    el.find(\"span.di" +
"scount.rate\").html(discountEl.val().replace(\"%\", \"\") + \"%\");\r\n                  " +
"  el.find(\"span.discounted.amount\").html(discountedAmount);\r\n                } e" +
"lse {\r\n                    el.find(\".discount.info\").hide();\r\n                };" +
"\r\n\r\n                if (isTaxableItem) {\r\n                    const tax = window" +
".round((discountedAmount || amount) * taxRate / 100, 2);\r\n                    co" +
"nst amountPlusTax = window.round((discountedAmount || amount) + tax, 2);\r\n\r\n    " +
"                //alert(discountedAmount);\r\n                    //alert(amount);" +
"\r\n\r\n                    el.find(\".tax.info .tax-amount\").html(tax);\r\n           " +
"         el.find(\".tax.info .tax-rate\").html(window.round(taxRate, 2));\r\n       " +
"             el.find(\".tax.info .amount-plus-tax\").html(amountPlusTax);\r\n       " +
"             el.find(\".tax.info\").show();\r\n                };\r\n\r\n               " +
" window.updateTotal();\r\n            };\r\n\r\n            quantityInput.on(\"keyup\", " +
"function () {\r\n                const el = $(this);\r\n                const parent" +
"Info = el.parent().parent();\r\n                updateItemTotal(parentInfo);\r\n    " +
"        });\r\n\r\n            discountInput.on(\"keyup\", function () {\r\n            " +
"    const el = $(this);\r\n\r\n                const rate = parseFloat(el.val());\r\n " +
"               if (rate > 100) {\r\n                    el.val(\"100\");\r\n          " +
"          return;\r\n                };\r\n\r\n                const parentInfo = el.p" +
"arent().parent();\r\n                updateItemTotal(parentInfo);\r\n            });" +
"\r\n\r\n            priceInput.on(\"keyup\", function () {\r\n                const el =" +
" $(this);\r\n                const parentInfo = el.parent().parent();\r\n           " +
"     updateItemTotal(parentInfo);\r\n            });\r\n\r\n            discountInput." +
"on(\"blur\", function () {\r\n                const el = $(this);\r\n                c" +
"onst value = el.val();\r\n\r\n                if (!value) {\r\n                    ret" +
"urn;\r\n                };\r\n\r\n                if (value.substr(value.length - 1) =" +
"== \"%\") {\r\n                    return;\r\n                };\r\n\r\n                el" +
".val(el.val() + \"%\");\r\n                const parentInfo = el.parent().parent();\r" +
"\n                updateItemTotal(parentInfo);\r\n            });\r\n\r\n            fu" +
"nction getPrice(el) {\r\n                function request(itemId, supplierId, unit" +
"Id) {\r\n                    var url = \"/dashboard/purchase/tasks/cost-price/{item" +
"Id}/{supplierId}/{unitId}\";\r\n                    url = url.replace(\"{itemId}\", i" +
"temId);\r\n                    url = url.replace(\"{supplierId}\", supplierId);\r\n   " +
"                 url = url.replace(\"{unitId}\", unitId);\r\n\r\n                    r" +
"eturn window.getAjaxRequest(url);\r\n                };\r\n\r\n                const i" +
"temId = el.attr(\"data-item-id\");\r\n                const supplierId = parseInt($(" +
"\"#SupplierSelect\").val() || 0);\r\n                const unitId = el.val();\r\n\r\n   " +
"             $(\".pos.purchase.segment\").addClass(\"loading\");\r\n                co" +
"nst ajax = request(itemId, supplierId, unitId);\r\n\r\n                ajax.success(" +
"function (response) {\r\n                    $(\".pos.purchase.segment\").removeClas" +
"s(\"loading\");\r\n                    const priceInput = el.parent().parent().paren" +
"t().find(\"input.price\");\r\n                    priceInput.val(response).trigger(\"" +
"keyup\");\r\n                });\r\n\r\n                ajax.fail(function (xhr) {\r\n   " +
"                 $(\".pos.purchase.segment\").removeClass(\"loading\");\r\n           " +
"         window.logAjaxErrorMessage(xhr);\r\n                });\r\n            };\r\n" +
"\r\n            unitSelect.on(\"change\", function () {\r\n                getPrice($(" +
"this));\r\n            });\r\n\r\n            item.on(\"contextmenu\", function (e) {\r\n " +
"               e.preventDefault();\r\n                const el = $(this);\r\n       " +
"         const inputEl = el.find(\".number.block input\");\r\n                const " +
"buttonEl = el.find(\".number.block button\");\r\n\r\n                inputEl.toggle();" +
"\r\n                buttonEl.toggle();\r\n            });\r\n\r\n            item.append" +
"To(targetEl);\r\n            quantityInput.trigger(\"keyup\");\r\n            window.u" +
"pdateTotal();\r\n        });\r\n    };\r\n\r\n    $(\"#SummaryItems div.discount .money i" +
"nput, \" +\r\n        \"#ReceiptSummary div.tender .money input\").keyup(function () " +
"{\r\n            window.updateTotal();\r\n        });\r\n\r\n    function updateTotal() " +
"{\r\n        const candidates = $(\"#PurchaseItems div.item\");\r\n        const amoun" +
"tEl = $(\"#SummaryItems div.amount .money\");\r\n\r\n        var totalPrice = 0;\r\n    " +
"    //var totalQuantity = 0;\r\n\r\n        $.each(candidates, function () {\r\n      " +
"      const el = $(this);\r\n            const quantityEl = el.find(\"input.quantit" +
"y\");\r\n            const discountEl = el.find(\"input.discount\");\r\n\r\n            c" +
"onst quantity = parseInt(quantityEl.val() || 0);\r\n            const discountRate" +
" = parseFloat(discountEl.val().replace(\"%\", \"\"));\r\n            const price = par" +
"seFloat(el.find(\"input.price\").val());\r\n            //var price = parseFloat(el." +
"attr(\"data-price\") || 0);\r\n\r\n            const amount = price * quantity;\r\n     " +
"       const discountedAmount = amount * ((100 - discountRate) / 100);\r\n\r\n      " +
"      totalPrice += (discountedAmount || amount);\r\n            //totalQuantity +" +
"= quantity;\r\n        });\r\n\r\n        totalPrice = window.round(totalPrice, 2);\r\n\r" +
"\n        amountEl.html(totalPrice);\r\n    };\r\n\r\n    function displayCategories() " +
"{\r\n        const categories = window.Enumerable.From(products).Distinct(function" +
" (x) { return x.ItemGroupName }).Select(function (x) { return x.ItemGroupName })" +
".ToArray();\r\n        var targetEl = $(\".cat.filter\");\r\n        $(\".category.list" +
"\").find(\".category\").remove();\r\n\r\n        targetEl.unbind(\"click\").bind(\"click\"," +
" function () {\r\n            displayProducts();\r\n            $(\".category\").remov" +
"eClass(\"selected\");\r\n            targetEl.hide();\r\n            initializeClickAn" +
"dAction();\r\n        });\r\n\r\n        $.each(categories, function () {\r\n           " +
" const category = $(\"<div class=\'category\' />\");\r\n            category.html(this" +
");\r\n\r\n            category.unbind(\"click\").bind(\"click\", function () {\r\n        " +
"        $(\".search.panel input\").val(\"\");\r\n                const el = $(this);\r\n" +
"                const name = el.text();\r\n\r\n                if (name) {\r\n        " +
"            displayProducts(name);\r\n                    $(\".category\").removeCla" +
"ss(\"selected\");\r\n                    el.addClass(\"selected\");\r\n\r\n               " +
"     targetEl.show();\r\n                } else {\r\n                    targetEl.hi" +
"de();\r\n                };\r\n\r\n                initializeClickAndAction();\r\n      " +
"      });\r\n\r\n            targetEl.before(category);\r\n        });\r\n    };\r\n\r\n    " +
"function displayProducts(category, searchQuery) {\r\n        var target = $(\"#POSI" +
"temList\");\r\n\r\n        var groupItems;\r\n\r\n        if (!category && !searchQuery) " +
"{\r\n            groupItems = products;\r\n        } else {\r\n            if (categor" +
"y && searchQuery) {\r\n                groupItems = window.Enumerable\r\n           " +
"         .From(products)\r\n                    .Where(function (x) {\r\n           " +
"             return x.ItemGroupName.toLowerCase() === category.toString().toLowe" +
"rCase()\r\n                            && x.ItemName.toLowerCase().indexOf(searchQ" +
"uery.toLowerCase()) > -1;\r\n                    }).ToArray();\r\n            } else" +
" if (!category && searchQuery) {\r\n                groupItems = window.Enumerable" +
"\r\n                    .From(products)\r\n                    .Where(function (x) {" +
"\r\n                        return x.ItemName.toLowerCase().indexOf(searchQuery.to" +
"LowerCase()) > -1;\r\n                    }).ToArray();\r\n            } else {\r\n   " +
"             groupItems = window.Enumerable\r\n                    .From(products)" +
"\r\n                    .Where(function (x) {\r\n                        return x.It" +
"emGroupName.toLowerCase() === category.toString().toLowerCase();\r\n              " +
"      }).ToArray();\r\n            };\r\n        };\r\n\r\n        groupItems = window.E" +
"numerable.From(groupItems).OrderBy(function(x) { return x.ItemId }).ToArray();\r\n" +
"\r\n        target.html(\"\").hide();\r\n\r\n        $.each(groupItems, function () {\r\n " +
"           const product = this;\r\n\r\n            const item = $(\"<div class=\'item" +
"\' />\");\r\n            item.attr(\"data-item-id\", product.ItemId);\r\n            ite" +
"m.attr(\"data-item-code\", product.ItemCode);\r\n            item.attr(\"data-item-na" +
"me\", product.ItemName);\r\n            item.attr(\"data-item-group\", product.ItemGr" +
"oupName);\r\n            item.attr(\"data-brand\", product.BrandName);\r\n            " +
"item.attr(\"data-unit-id\", product.UnitId);\r\n            item.attr(\"data-valid-un" +
"its\", product.ValidUnits);\r\n            item.attr(\"data-barcode\", product.Barcod" +
"e);\r\n            item.attr(\"data-photo\", product.Photo);\r\n            item.attr(" +
"\"data-cost-price\", product.CostPrice);\r\n            item.attr(\"data-is-taxable-i" +
"tem\", product.IsTaxableItem);\r\n\r\n            if (product.HotItem) {\r\n           " +
"     item.addClass(\"hot\");\r\n            };\r\n\r\n            const info = $(\"<div c" +
"lass=\'info\' />\");\r\n\r\n            const price = $(\"<div class=\'price\' />\");\r\n    " +
"        price.html(product.CostPrice);\r\n\r\n            price.appendTo(info);\r\n\r\n\r" +
"\n            const photo = $(\"<div class=\'photo\' />\");\r\n            const img = " +
"$(\"<img />\");\r\n\r\n            if (product.Photo) {\r\n                img.attr(\"src" +
"\", product.Photo + \"?Height=200&Width=200\");\r\n            };\r\n\r\n            img." +
"appendTo(photo);\r\n            photo.appendTo(info);\r\n\r\n            const name = " +
"$(\"<div class=\'name\' />\");\r\n            name.html(product.ItemName);\r\n\r\n        " +
"    name.appendTo(info);\r\n\r\n            info.appendTo(item);\r\n            item.a" +
"ppendTo(target);\r\n        });\r\n\r\n        if (searchQuery) {\r\n            target." +
"show();\r\n            return;\r\n        };\r\n\r\n        target.fadeIn(500);\r\n    };\r" +
"\n\r\n</script>\r\n\r\n<script>\r\n    $(\"#ClearScreenButton\")\r\n        .unbind(\"click\")\r" +
"\n        .bind(\"click\",\r\n            function () {\r\n                clearScreen(" +
");\r\n            });\r\n\r\n    function clearScreen() {\r\n        $(\"#PurchaseItems\")" +
".html(\"\");\r\n        window.updateTotal();\r\n    };\r\n</script>\r\n\r\n<script>\r\n    fu" +
"nction displayFieldBinder(el, url) {\r\n        function request() {\r\n            " +
"return window.getAjaxRequest(url);\r\n        };\r\n\r\n        const ajax = request()" +
";\r\n\r\n        ajax.success(function (response) {\r\n            var options = \"\";\r\n" +
"\r\n            $.each(response, function () {\r\n                var option = \"<opt" +
"ion value=\'{key}\'>{value}</option>\";\r\n                option = option.replace(\"{" +
"key}\", this.Key);\r\n                option = option.replace(\"{value}\", this.Value" +
");\r\n\r\n                options += option;\r\n            });\r\n\r\n            el.html" +
"(options);\r\n        });\r\n    };\r\n\r\n    function loadStores() {\r\n        displayF" +
"ieldBinder($(\"#StoreSelect\"), \"/api/forms/inventory/stores/display-fields\");\r\n  " +
"  };\r\n\r\n    function loadShippers() {\r\n        displayFieldBinder($(\"#ShipperSel" +
"ect\"), \"/api/forms/inventory/shippers/display-fields\");\r\n    };\r\n\r\n    function " +
"loadCostCenters() {\r\n        displayFieldBinder($(\"#CostCenterSelect\"), \"/api/fo" +
"rms/finance/cost-centers/display-fields\");\r\n    };\r\n\r\n    function loadPriceType" +
"s() {\r\n        displayFieldBinder($(\"#PriceTypeSelect\"), \"/api/forms/purchase/pr" +
"ice-types/display-fields\");\r\n    };\r\n\r\n    function loadSuppliers() {\r\n        d" +
"isplayFieldBinder($(\"#SupplierSelect\"), \"/api/forms/inventory/suppliers/display-" +
"fields\");\r\n    };\r\n\r\n    loadStores();\r\n    loadPriceTypes();\r\n    loadSuppliers" +
"();\r\n    loadCostCenters();\r\n    loadShippers();\r\n</script>\r\n\r\n<script>\r\n    set" +
"Timeout(function() {\r\n        $(\".decimal\").number(true, window.currencyDecimalP" +
"laces, \".\", \"\");\r\n    }, 100);\r\n</script>\r\n\r\n<script>\r\n    function getTaxRate()" +
" {\r\n        function request() {\r\n            const url = \"/api/forms/finance/ta" +
"x-setups/get-where/-1\";\r\n            const filters = [];\r\n            filters.pu" +
"sh(window.getAjaxColumnFilter(\"WHERE\", \"OfficeId\", \"int\", window.FilterCondition" +
"s.IsEqualTo, window.metaView.OfficeId));\r\n\r\n            return window.getAjaxReq" +
"uest(url, \"POST\", filters);\r\n        };\r\n\r\n        const ajax = request();\r\n\r\n  " +
"      ajax.success(function (response) {\r\n            const salesTaxRate = windo" +
"w.parseFloat(response[0].SalesTaxRate);\r\n            $(\"#SalesTaxRateHidden\").va" +
"l(salesTaxRate);\r\n        });\r\n    };\r\n\r\n    getTaxRate();\r\n</script>");

        }
    }
}
#pragma warning restore 1591
