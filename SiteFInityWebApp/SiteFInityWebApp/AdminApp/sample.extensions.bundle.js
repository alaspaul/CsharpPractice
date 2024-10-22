/******/ (() => { // webpackBootstrap
/******/ 	var __webpack_modules__ = ({

/***/ "ext_mod_id_1728986549046_41":
/*!******************************************************!*\
  !*** ./samples/commands-extender/commands-filter.ts ***!
  \******************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CUSTOM_COMMANDS_FILTER": () => (/* binding */ CUSTOM_COMMANDS_FILTER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_2__);



let CustomCommandsFilter = class CustomCommandsFilter {
    filter(operations, data) {
        if (data.dataItem.metadata.setName === "newsitems") {
            return operations.filter(x => x.name !== "Delete");
        }
        return operations;
    }
};
CustomCommandsFilter = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_2__.Injectable)()
], CustomCommandsFilter);
const CUSTOM_COMMANDS_FILTER = {
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__.COMMANDS_FILTER_TOKEN,
    useClass: CustomCommandsFilter,
    multi: true
};


/***/ }),

/***/ "ext_mod_id_1728986549046_38":
/*!********************************************************!*\
  !*** ./samples/commands-extender/commands-provider.ts ***!
  \********************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "COMMANDS_PROVIDER": () => (/* binding */ COMMANDS_PROVIDER),
/* harmony export */   "LIST_SELECTED_ITEMS_COMMAND": () => (/* binding */ LIST_SELECTED_ITEMS_COMMAND),
/* harmony export */   "NOTIFICATION_COMMAND": () => (/* binding */ NOTIFICATION_COMMAND)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1728986549046_52");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _print_preview_command__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./print-preview.command */ "ext_mod_id_1728986549046_40");
/* harmony import */ var _list_selected_items_command__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./list-selected-items.command */ "ext_mod_id_1728986549046_42");
/* harmony import */ var _notification_command__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./notification.command */ "ext_mod_id_1728986549046_43");







/**
 * The category name in which to place the custom commands.
 */
const CUSTOM_CATEGORY_NAME = "Custom";
/**
 * The command model containing the metadata of the command.
 * The ordinal indicates where to place the command in the dropdown.
 */
const CUSTOM_COMMAND_BASE = {
    name: "Custom",
    title: "Print preview",
    ordinal: -1,
    category: CUSTOM_CATEGORY_NAME
};
/**
 * The category model.
 */
const CUSTOM_CATEGORY = {
    name: CUSTOM_CATEGORY_NAME,
    title: "Custom commands"
};
/**
 * The command model containing the metadata of the command.
 */
const LIST_SELECTED_ITEMS_COMMAND = {
    name: "List",
    title: "List selected items",
    category: CUSTOM_CATEGORY_NAME,
    ordinal: CUSTOM_COMMAND_BASE.ordinal + 1
};
/**
 * The command model containing the metadata of the command.
 */
const NOTIFICATION_COMMAND = {
    name: "Notification",
    title: "Show notification",
    category: CUSTOM_CATEGORY_NAME,
    ordinal: CUSTOM_COMMAND_BASE.ordinal + 1
};
/**
 * The command provider provides the necessary commands back to the AdminApp.
 */
let DynamicItemIndexCommandProvider = class DynamicItemIndexCommandProvider {
    /**
     * The method that gets invoked asking for the command models when the action menu is constructed.
     * @param data The data needed to determine the types of command to return
     * and where to place them - in the list or in edit mode
     */
    getCommands(data) {
        // the commands to be returned
        const commands = [];
        this.addPrintPreviewCommand(data, commands);
        this.addListSelectedItemsCommand(data, commands);
        this.addNotificationCommand(data, commands);
        // return an observable here, because generating the actions might be a time consuming operation
        return (0,rxjs__WEBPACK_IMPORTED_MODULE_2__.of)(commands);
    }
    /**
     * The method that gets invoked asking for the category models when the action menu is constructed.
     * Categories are used to group similar commands in the action menu
     * @param data The data needed to determine the types of command to return and where to place them - in the list or in edit mode
     */
    // eslint-disable-next-line  @typescript-eslint/no-unused-vars
    getCategories(data) {
        return (0,rxjs__WEBPACK_IMPORTED_MODULE_2__.of)([CUSTOM_CATEGORY]);
    }
    addPrintPreviewCommand(data, commands) {
        // we wish to inject this command only in the list view
        if (data.target === _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__.CommandsTarget.List && data.dataItem) {
            const previewCommand = Object.assign({}, CUSTOM_COMMAND_BASE);
            // assign an injection token or just the class
            previewCommand.token = {
                type: _print_preview_command__WEBPACK_IMPORTED_MODULE_4__.PrintPreviewCommand,
                // assign custom properties to be passed in the context
                properties: {
                    dataItem: data.dataItem
                }
            };
            commands.push(previewCommand);
        }
    }
    addListSelectedItemsCommand(data, commands) {
        if (data.target === _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__.CommandsTarget.Bulk) {
            const bulkCommand = Object.assign({}, LIST_SELECTED_ITEMS_COMMAND);
            bulkCommand.token = {
                type: _list_selected_items_command__WEBPACK_IMPORTED_MODULE_5__.ListSelectedItemsCommand
            };
            commands.push(bulkCommand);
        }
    }
    addNotificationCommand(data, commands) {
        // we wish to inject this command only in the edit item view
        if (data.target === _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__.CommandsTarget.Edit) {
            const notificationCommand = Object.assign({}, NOTIFICATION_COMMAND);
            // assign an injection token or just the class
            notificationCommand.token = {
                type: _notification_command__WEBPACK_IMPORTED_MODULE_6__.NotificationCommand,
                // assign custom properties to be passed in the context
                properties: {
                    dataItem: data.dataItem
                }
            };
            commands.push(notificationCommand);
        }
    }
};
DynamicItemIndexCommandProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_3__.Injectable)()
], DynamicItemIndexCommandProvider);
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const COMMANDS_PROVIDER = {
    useClass: DynamicItemIndexCommandProvider,
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__.COMMANDS_TOKEN
};


/***/ }),

/***/ "ext_mod_id_1728986549046_3":
/*!********************************************!*\
  !*** ./samples/commands-extender/index.ts ***!
  \********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CommandsExtenderModule": () => (/* binding */ CommandsExtenderModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "ext_mod_id_1728986549046_50");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_router__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common */ "ext_mod_id_1728986549046_47");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_angular_common__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "ext_mod_id_1728986549046_49");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_angular_common_http__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _commands_provider__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./commands-provider */ "ext_mod_id_1728986549046_38");
/* harmony import */ var _print_preview_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./print-preview.component */ "ext_mod_id_1728986549046_39");
/* harmony import */ var _print_preview_command__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./print-preview.command */ "ext_mod_id_1728986549046_40");
/* harmony import */ var _commands_filter__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./commands-filter */ "ext_mod_id_1728986549046_41");
/* harmony import */ var _list_selected_items_command__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./list-selected-items.command */ "ext_mod_id_1728986549046_42");
/* harmony import */ var _notification_command__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ./notification.command */ "ext_mod_id_1728986549046_43");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_11__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_11___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_11__);












/**
 * The command extender module.
 */
let CommandsExtenderModule = class CommandsExtenderModule {
};
CommandsExtenderModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        declarations: [
            _print_preview_component__WEBPACK_IMPORTED_MODULE_6__.PrintPreviewComponent
        ],
        providers: [
            _commands_provider__WEBPACK_IMPORTED_MODULE_5__.COMMANDS_PROVIDER,
            _commands_filter__WEBPACK_IMPORTED_MODULE_8__.CUSTOM_COMMANDS_FILTER,
            _print_preview_command__WEBPACK_IMPORTED_MODULE_7__.PrintPreviewCommand,
            _list_selected_items_command__WEBPACK_IMPORTED_MODULE_9__.ListSelectedItemsCommand,
            _notification_command__WEBPACK_IMPORTED_MODULE_10__.NotificationCommand
        ],
        imports: [
            _angular_router__WEBPACK_IMPORTED_MODULE_2__.RouterModule.forChild([{ path: "print-preview", component: _print_preview_component__WEBPACK_IMPORTED_MODULE_6__.PrintPreviewComponent, canActivate: [_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_11__.ConfigurationGuard, _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_11__.AuthGuard] }]),
            _angular_common__WEBPACK_IMPORTED_MODULE_3__.CommonModule,
            _angular_common_http__WEBPACK_IMPORTED_MODULE_4__.HttpClientModule
        ]
    })
], CommandsExtenderModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_42":
/*!******************************************************************!*\
  !*** ./samples/commands-extender/list-selected-items.command.ts ***!
  \******************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ListSelectedItemsCommand": () => (/* binding */ ListSelectedItemsCommand)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1728986549046_52");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_2__);



/**
 * Serves as a command that gets invoked when the list items bulk action
 * in the actions menu is clicked.
 */
let ListSelectedItemsCommand = class ListSelectedItemsCommand {
    constructor() {
        /**
         * Indicates the command is executed once and not for every item selected.
         */
        this.executeOnceInBulk = true;
    }
    /**
     * This method gets invoked when the list items action is clicked.
     * @param context The context that contains data for the executed bulk action.
     */
    execute(context) {
        // get the selected items from the context.
        const selectedItems = context.data.selectedItems;
        console.log(`Custom bulk command executed. Selected items: ${selectedItems.map(x => x.title).join(", ")}`);
        const result = {
            success: true,
            failedItemsIds: [],
            succeededItemsIds: selectedItems.map(x => x.key)
        };
        return (0,rxjs__WEBPACK_IMPORTED_MODULE_2__.of)(result);
    }
};
ListSelectedItemsCommand = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], ListSelectedItemsCommand);



/***/ }),

/***/ "ext_mod_id_1728986549046_43":
/*!***********************************************************!*\
  !*** ./samples/commands-extender/notification.command.ts ***!
  \***********************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "NotificationCommand": () => (/* binding */ NotificationCommand)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "ext_mod_id_1728986549046_50");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_router__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1728986549046_52");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__);





/**
 * Serves as a command that gets invoked when the notification action button is clicked
 */
let NotificationCommand = class NotificationCommand {
    constructor(router, notificationService) {
        this.router = router;
        this.notificationService = notificationService;
    }
    /**
     * This method gets invoked when the notification action button is clicked
     * @param context The context that contains the data item and the custom properties from the CommandProvider.
     */
    execute(context) {
        // get the data item from the context.
        const dataItem = context.data.dataItem;
        // publish a notification
        const notificationInfo = {
            message: `Notification command executed on item: ${dataItem.title}`,
            look: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__.NOTIFICATION_LOOK_SUCCESS,
            duration: 7000,
            filterParam: "item-edit"
        };
        this.notificationService.publishBasicNotification(notificationInfo);
        return (0,rxjs__WEBPACK_IMPORTED_MODULE_3__.of)(true);
    }
};
NotificationCommand.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__.Router },
    { type: undefined, decorators: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_1__.Inject, args: [_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__.NOTIFICATION_SERVICE,] }] }
];
NotificationCommand = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)(),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__.Router, Object])
], NotificationCommand);



/***/ }),

/***/ "ext_mod_id_1728986549046_40":
/*!************************************************************!*\
  !*** ./samples/commands-extender/print-preview.command.ts ***!
  \************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "PrintPreviewCommand": () => (/* binding */ PrintPreviewCommand)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/router */ "ext_mod_id_1728986549046_50");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_router__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1728986549046_52");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_3__);




/**
 * Serves as a command that gets invoked when the print preview action
 * in the actions menu is clicked.
 */
let PrintPreviewCommand = class PrintPreviewCommand {
    /**
     * Initializes a new instance of the PrintPreviewCommand.
     * @param router The router that is used to navigate.
     */
    constructor(router) {
        this.router = router;
    }
    /**
     * This method gets invoked when the print preview action is clicked.
     * @param context The context that contains the data item and the custom properties from the CommandProvider.
     */
    execute(context) {
        // get the data item from the context.
        const dataItem = context.data.dataItem;
        // construct the query params so the component that we navigate to
        // will know which data item to fetch
        const currentQueryParams = {
            entitySet: dataItem.metadata.setName,
            id: dataItem.key,
            provider: dataItem.provider
        };
        // navigate to the print-preview route using the query params.
        // return an observable here, because this might be a time consuming operation
        const url = `/print-preview`;
        const navPromise = this.router.navigate([url], { queryParams: currentQueryParams });
        return (0,rxjs__WEBPACK_IMPORTED_MODULE_3__.from)(navPromise);
    }
};
PrintPreviewCommand.ctorParameters = () => [
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_2__.Router }
];
PrintPreviewCommand = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)(),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [_angular_router__WEBPACK_IMPORTED_MODULE_2__.Router])
], PrintPreviewCommand);



/***/ }),

/***/ "ext_mod_id_1728986549046_39":
/*!**************************************************************!*\
  !*** ./samples/commands-extender/print-preview.component.ts ***!
  \**************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "PrintPreviewComponent": () => (/* binding */ PrintPreviewComponent)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _print_preview_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./print-preview.component.html?ngResource */ "ext_mod_id_1728986549046_70");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/router */ "ext_mod_id_1728986549046_50");
/* harmony import */ var _angular_router__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_angular_router__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/common/http */ "ext_mod_id_1728986549046_49");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_angular_common_http__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! rxjs/operators */ "ext_mod_id_1728986549046_65");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_6___default = /*#__PURE__*/__webpack_require__.n(rxjs_operators__WEBPACK_IMPORTED_MODULE_6__);







/**
 * A component that loads the data item from the OData rest services and displays the title of the data item.
 */
let PrintPreviewComponent = class PrintPreviewComponent {
    /**
     * Initializes a new instance of the PrintPreviewComponent
     * @param http The http client service used for making http requests.
     * @param route The current navigated route.
     */
    constructor(http, route) {
        this.http = http;
        this.route = route;
    }
    /**
     * ngOnInit lifecycle hook. Attached here so we can fetch the data on initialization
     */
    ngOnInit() {
        // get the route params that contain the metadata needed to load the data item
        const routeParams = this.route.snapshot.queryParams;
        // http prefix is dynamically replaced with the actual url of sitefinity
        const url = `${_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_5__.HTTP_PREFIX}/sf/system/${routeParams.entitySet}(${routeParams.id})` + (routeParams.provider ? `?sf_provider=${routeParams.provider}` : ``);
        // delay so there is always a minimum loading time
        this.http.get(url).pipe((0,rxjs_operators__WEBPACK_IMPORTED_MODULE_6__.delay)(500)).subscribe((dataItem) => {
            this.dataItem = dataItem;
        });
    }
};
PrintPreviewComponent.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_4__.HttpClient },
    { type: _angular_router__WEBPACK_IMPORTED_MODULE_3__.ActivatedRoute }
];
PrintPreviewComponent = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_2__.Component)({
        template: _print_preview_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__
    }),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_4__.HttpClient,
        _angular_router__WEBPACK_IMPORTED_MODULE_3__.ActivatedRoute])
], PrintPreviewComponent);



/***/ }),

/***/ "ext_mod_id_1728986549046_20":
/*!***********************************************************************************!*\
  !*** ./samples/custom-fields/array-of-guids/array-of-guids-readonly.component.ts ***!
  \***********************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ArrayOfGUIDsReadonlyComponent": () => (/* binding */ ArrayOfGUIDsReadonlyComponent)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _array_of_guids_readonly_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./array-of-guids-readonly.component.html?ngResource */ "ext_mod_id_1728986549046_56");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3__);




/**
 * The component used to display the field in read only mode.
 */
let ArrayOfGUIDsReadonlyComponent = class ArrayOfGUIDsReadonlyComponent extends _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3__.FieldBase {
};
ArrayOfGUIDsReadonlyComponent = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_2__.Component)({
        template: _array_of_guids_readonly_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__
    })
], ArrayOfGUIDsReadonlyComponent);



/***/ }),

/***/ "ext_mod_id_1728986549046_21":
/*!********************************************************************************!*\
  !*** ./samples/custom-fields/array-of-guids/array-of-guids-write.component.ts ***!
  \********************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ArrayOfGUIDsWriteComponent": () => (/* binding */ ArrayOfGUIDsWriteComponent)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _array_of_guids_write_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./array-of-guids-write.component.html?ngResource */ "ext_mod_id_1728986549046_57");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3__);




/**
 * The component used to display the field in write mode.
 */
let ArrayOfGUIDsWriteComponent = class ArrayOfGUIDsWriteComponent extends _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3__.FieldBase {
    writeValue(value) {
        if (typeof value === "string") {
            const arrayValue = value ? value.split(",").map(item => item.trim()) : [];
            super.writeValue(arrayValue);
        }
        else {
            super.writeValue(value);
        }
    }
};
ArrayOfGUIDsWriteComponent = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_2__.Component)({
        template: _array_of_guids_write_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__
    })
], ArrayOfGUIDsWriteComponent);



/***/ }),

/***/ "ext_mod_id_1728986549046_17":
/*!******************************************************************!*\
  !*** ./samples/custom-fields/custom-field-readonly.component.ts ***!
  \******************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CustomInputReadonlyComponent": () => (/* binding */ CustomInputReadonlyComponent)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _custom_field_readonly_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./custom-field-readonly.component.html?ngResource */ "ext_mod_id_1728986549046_55");
/* harmony import */ var C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_samples_custom_fields_custom_field_readonly_component_ts_css_ngResource_C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_node_modules_ngtools_webpack_src_loaders_inline_resource_js_data_CiAgICAgICAgLmN1c3RvbS10aXRsZS1pbnB1dCB7CiAgICAgICAgICAgIGJvcmRlcjogMDsKICAgICAgICAgICAgcGFkZGluZzogMDsKICAgICAgICAgICAgZm9udC13ZWlnaHQ6IDcwMDsKICAgICAgICAgICAgZm9udC1zaXplOiAzZW07CiAgICAgICAgICAgIHdpZHRoOiAxMDAlOwogICAgICAgICAgICBjb2xvcjogIzY2NjsKICAgICAgICB9CiAgICAgICAg_C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_samples_custom_fields_custom_field_readonly_component_ts__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./samples/custom-fields/custom-field-readonly.component.ts.css?ngResource!=!./node_modules/@ngtools/webpack/src/loaders/inline-resource.js?data=CiAgICAgICAgLmN1c3RvbS10aXRsZS1pbnB1dCB7CiAgICAgICAgICAgIGJvcmRlcjogMDsKICAgICAgICAgICAgcGFkZGluZzogMDsKICAgICAgICAgICAgZm9udC13ZWlnaHQ6IDcwMDsKICAgICAgICAgICAgZm9udC1zaXplOiAzZW07CiAgICAgICAgICAgIHdpZHRoOiAxMDAlOwogICAgICAgICAgICBjb2xvcjogIzY2NjsKICAgICAgICB9CiAgICAgICAg!./samples/custom-fields/custom-field-readonly.component.ts */ "ext_mod_id_1728986549046_77");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__);





/**
 * The component used to display the field in read only mode.
 * One can use inline template & styles OR templateUrl & styleUrls OR a mixture of that like here. See the -write.component.ts version for the write mode type.
 */
let CustomInputReadonlyComponent = class CustomInputReadonlyComponent extends _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__.FieldBase {
};
CustomInputReadonlyComponent = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_3__.Component)({
        template: _custom_field_readonly_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__,
        styles: [C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_samples_custom_fields_custom_field_readonly_component_ts_css_ngResource_C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_node_modules_ngtools_webpack_src_loaders_inline_resource_js_data_CiAgICAgICAgLmN1c3RvbS10aXRsZS1pbnB1dCB7CiAgICAgICAgICAgIGJvcmRlcjogMDsKICAgICAgICAgICAgcGFkZGluZzogMDsKICAgICAgICAgICAgZm9udC13ZWlnaHQ6IDcwMDsKICAgICAgICAgICAgZm9udC1zaXplOiAzZW07CiAgICAgICAgICAgIHdpZHRoOiAxMDAlOwogICAgICAgICAgICBjb2xvcjogIzY2NjsKICAgICAgICB9CiAgICAgICAg_C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_samples_custom_fields_custom_field_readonly_component_ts__WEBPACK_IMPORTED_MODULE_2__]
    })
], CustomInputReadonlyComponent);



/***/ }),

/***/ "ext_mod_id_1728986549046_18":
/*!***************************************************************!*\
  !*** ./samples/custom-fields/custom-field-write.component.ts ***!
  \***************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CustomInputWriteComponent": () => (/* binding */ CustomInputWriteComponent)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _custom_field_write_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./custom-field-write.component.html?ngResource */ "ext_mod_id_1728986549046_54");
/* harmony import */ var _custom_field_write_component_css_ngResource__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./custom-field-write.component.css?ngResource */ "ext_mod_id_1728986549046_78");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__);





/**
 * The component used to display the field in write mode.
 * One can use inline template & styles OR templateUrl & styleUrls, like here OR mixture of that. See -readonly.component.ts version for the read mode type.
 */
let CustomInputWriteComponent = class CustomInputWriteComponent extends _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__.FieldBase {
    processErrors(errors) {
        // the pattern validator in the custom-field.settings file sets a pattern object
        // that holds information regarding the validation. If the pattern property exists
        // the validation has not passed and we can return an error message
        if (errors.pattern) {
            return ["Invalid email !"];
        }
        return [];
    }
};
CustomInputWriteComponent = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_3__.Component)({
        template: _custom_field_write_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__,
        styles: [_custom_field_write_component_css_ngResource__WEBPACK_IMPORTED_MODULE_2__]
    })
], CustomInputWriteComponent);



/***/ }),

/***/ "ext_mod_id_1728986549046_66":
/*!********************************************************!*\
  !*** ./samples/custom-fields/custom-field.settings.ts ***!
  \********************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CustomShortTextSettings": () => (/* binding */ CustomShortTextSettings)
/* harmony export */ });
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/forms */ "ext_mod_id_1728986549046_46");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_forms__WEBPACK_IMPORTED_MODULE_1__);


/**
 * A settings object to configure the fields behavior. This object is assigned to the field via the settings property on the FieldBase class.
 * Examples of such are validations, the title to be shown and so on.
 */
class CustomShortTextSettings extends _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_0__.SettingsBase {
    init(metadata) {
        super.init(metadata);
        // set the recommended characters for this field to 20
        this.recommendedCharacters = 20;
    }
    getValidators() {
        const baseValidators = super.getValidators();
        // add an email pattern validator
        const emailPattern = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
        const emailValidator = _angular_forms__WEBPACK_IMPORTED_MODULE_1__.Validators.pattern(emailPattern);
        baseValidators.push(emailValidator);
        return baseValidators;
    }
}


/***/ }),

/***/ "ext_mod_id_1728986549046_19":
/*!*********************************************************!*\
  !*** ./samples/custom-fields/custom-fields-provider.ts ***!
  \*********************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CUSTOM_FIELDS_PROVIDER": () => (/* binding */ CUSTOM_FIELDS_PROVIDER),
/* harmony export */   "CustomFieldsProvider": () => (/* binding */ CustomFieldsProvider)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _custom_field_readonly_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./custom-field-readonly.component */ "ext_mod_id_1728986549046_17");
/* harmony import */ var _custom_field_write_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./custom-field-write.component */ "ext_mod_id_1728986549046_18");
/* harmony import */ var _custom_field_settings__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./custom-field.settings */ "ext_mod_id_1728986549046_66");
/* harmony import */ var _array_of_guids_array_of_guids_write_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./array-of-guids/array-of-guids-write.component */ "ext_mod_id_1728986549046_21");
/* harmony import */ var _array_of_guids_array_of_guids_readonly_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./array-of-guids/array-of-guids-readonly.component */ "ext_mod_id_1728986549046_20");








/**
 * The fields provider provides the overridden fields back to the AdminApp.
 */
let CustomFieldsProvider = class CustomFieldsProvider {
    constructor() {
        this.customFieldsMappings = [];
        this.registerCustomComponents();
    }
    /**
     * This method gets called before each field is instantiated, allowing custom fields to be plugged in for any type.
     * @param fieldRegistryKey The metadata needed to determine which field to display.
     */
    overrideField(fieldRegistryKey) {
        const registration = this.findRegistration(fieldRegistryKey);
        return registration;
    }
    /**
     * This method finds an implementation of the field to be overridden.
     * @param fieldRegistryKey The metadata needed to determine which field to display.
     */
    findRegistration(fieldRegistryKey) {
        for (const pair of this.customFieldsMappings) {
            if (fieldRegistryKey.fieldName === pair.key.fieldName &&
                fieldRegistryKey.fieldType === pair.key.fieldType &&
                fieldRegistryKey.typeName === pair.key.typeName) {
                return pair.registration;
            }
            if (pair.key.fieldName === null &&
                pair.key.typeName === null &&
                fieldRegistryKey.fieldType === pair.key.fieldType) {
                return pair.registration;
            }
        }
        return null;
    }
    /**
     * Initializes the custom field(component) registrations.
     */
    registerCustomComponents() {
        // The field name is the name which identifies the field uniquely.
        // The typename is the OData entity set name. It matches the url segment when navigating
        // to the list view of the specific type.
        const customInputKey = {
            fieldName: "Title",
            fieldType: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.FieldTypes.shortTextDefault,
            typeName: "newsitems"
        };
        // The result field registration that will be returned to the AdminApp.
        const customInputRegistration = {
            writeComponent: _custom_field_write_component__WEBPACK_IMPORTED_MODULE_4__.CustomInputWriteComponent,
            readComponent: _custom_field_readonly_component__WEBPACK_IMPORTED_MODULE_3__.CustomInputReadonlyComponent,
            settingsType: _custom_field_settings__WEBPACK_IMPORTED_MODULE_5__.CustomShortTextSettings
        };
        const customFieldRegistrationPair = {
            key: customInputKey,
            registration: customInputRegistration
        };
        this.customFieldsMappings.push(customFieldRegistrationPair);
        // Registration of Array of GUIDs custom field
        const arrayOfGUIDsKey = {
            fieldName: null,
            fieldType: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.FieldTypes.arrayOfGUIDs,
            typeName: null
        };
        const arrayOfGUIDsRegistration = {
            writeComponent: _array_of_guids_array_of_guids_write_component__WEBPACK_IMPORTED_MODULE_6__.ArrayOfGUIDsWriteComponent,
            readComponent: _array_of_guids_array_of_guids_readonly_component__WEBPACK_IMPORTED_MODULE_7__.ArrayOfGUIDsReadonlyComponent,
            settingsType: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.SettingsBase
        };
        const arrayOfGUIDsRegistrationPair = {
            key: arrayOfGUIDsKey,
            registration: arrayOfGUIDsRegistration
        };
        this.customFieldsMappings.push(arrayOfGUIDsRegistrationPair);
    }
};
CustomFieldsProvider.ctorParameters = () => [];
CustomFieldsProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)(),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [])
], CustomFieldsProvider);

/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const CUSTOM_FIELDS_PROVIDER = {
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.FIELDS_PROVIDER_TOKEN,
    useClass: CustomFieldsProvider,
    multi: true
};


/***/ }),

/***/ "ext_mod_id_1728986549046_2":
/*!****************************************!*\
  !*** ./samples/custom-fields/index.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CustomFieldsModule": () => (/* binding */ CustomFieldsModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/forms */ "ext_mod_id_1728986549046_46");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_forms__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _custom_field_readonly_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./custom-field-readonly.component */ "ext_mod_id_1728986549046_17");
/* harmony import */ var _custom_field_write_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./custom-field-write.component */ "ext_mod_id_1728986549046_18");
/* harmony import */ var _custom_fields_provider__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./custom-fields-provider */ "ext_mod_id_1728986549046_19");
/* harmony import */ var _array_of_guids_array_of_guids_readonly_component__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./array-of-guids/array-of-guids-readonly.component */ "ext_mod_id_1728986549046_20");
/* harmony import */ var _array_of_guids_array_of_guids_write_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./array-of-guids/array-of-guids-write.component */ "ext_mod_id_1728986549046_21");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_8___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_8__);









/**
 * The custom fields module.
 */
let CustomFieldsModule = class CustomFieldsModule {
};
CustomFieldsModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        declarations: [
            _custom_field_readonly_component__WEBPACK_IMPORTED_MODULE_3__.CustomInputReadonlyComponent,
            _custom_field_write_component__WEBPACK_IMPORTED_MODULE_4__.CustomInputWriteComponent,
            _array_of_guids_array_of_guids_readonly_component__WEBPACK_IMPORTED_MODULE_6__.ArrayOfGUIDsReadonlyComponent,
            _array_of_guids_array_of_guids_write_component__WEBPACK_IMPORTED_MODULE_7__.ArrayOfGUIDsWriteComponent
        ],
        providers: [
            _custom_fields_provider__WEBPACK_IMPORTED_MODULE_5__.CUSTOM_FIELDS_PROVIDER
        ],
        // import the framework module as it holds the components that the AdminApp uses
        // for a list of components see
        imports: [_angular_forms__WEBPACK_IMPORTED_MODULE_2__.FormsModule, _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_8__.FrameworkModule]
    })
], CustomFieldsModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_16":
/*!***********************************************************************************************!*\
  !*** ./samples/custom-system-notifications-icons/custom-system-notification-icon-provider.ts ***!
  \***********************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CUSTOM_SYSTEM_NOTIFICATION_ICON_PROVIDER": () => (/* binding */ CUSTOM_SYSTEM_NOTIFICATION_ICON_PROVIDER),
/* harmony export */   "CustomSystemNotificationIconProvider": () => (/* binding */ CustomSystemNotificationIconProvider)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



const DEFAULT_ICON = "check";
const FIRST_CUSTOM_ICON = "user";
const VIDEO_PUBLISHED_ICON = "film";
const NEW_FORM_RESPONSE_ICON = "form-response";
let CustomSystemNotificationIconProvider = class CustomSystemNotificationIconProvider {
    parseIcon(key) {
        switch (key) {
            // custom icons
            case "user-created":
                return FIRST_CUSTOM_ICON;
            case "video-published":
                return VIDEO_PUBLISHED_ICON;
            // override the default form resoinse notification icon
            case _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.SYSTEM_NOTIFICATION_KEYS.FORM_RESPONSE:
                return NEW_FORM_RESPONSE_ICON;
            // override the default icon
            default:
                return DEFAULT_ICON;
        }
    }
};
CustomSystemNotificationIconProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], CustomSystemNotificationIconProvider);

const CUSTOM_SYSTEM_NOTIFICATION_ICON_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.SYSTEM_NOTIFICATION_ICON_TOKEN,
    useClass: CustomSystemNotificationIconProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_10":
/*!************************************************************!*\
  !*** ./samples/custom-system-notifications-icons/index.ts ***!
  \************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "SystemNotificationsIconsExtenderModule": () => (/* binding */ SystemNotificationsIconsExtenderModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _custom_system_notification_icon_provider__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./custom-system-notification-icon-provider */ "ext_mod_id_1728986549046_16");



/**
 * The notifications icons extender module.
 */
let SystemNotificationsIconsExtenderModule = class SystemNotificationsIconsExtenderModule {
};
SystemNotificationsIconsExtenderModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        providers: [
            _custom_system_notification_icon_provider__WEBPACK_IMPORTED_MODULE_2__.CUSTOM_SYSTEM_NOTIFICATION_ICON_PROVIDER
        ]
    })
], SystemNotificationsIconsExtenderModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_4":
/*!******************************************!*\
  !*** ./samples/editor-extender/index.ts ***!
  \******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "EditorExtenderModule": () => (/* binding */ EditorExtenderModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "ext_mod_id_1728986549046_47");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_common__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _word_count_word_count_provider__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./word-count/word-count-provider */ "ext_mod_id_1728986549046_26");
/* harmony import */ var _sitefinity_videos_sitefinity_videos_toolbar_item_provider__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./sitefinity-videos/sitefinity-videos-toolbar-item-provider */ "ext_mod_id_1728986549046_28");
/* harmony import */ var _switch_text_direction_switch_text_direction_provider__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./switch-text-direction/switch-text-direction.provider */ "ext_mod_id_1728986549046_27");
/* harmony import */ var _insert_symbol_insert_symbol_provider__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./insert-symbol/insert-symbol.provider */ "ext_mod_id_1728986549046_29");
/* harmony import */ var _spell_check_edit_menu_spell_check_provider__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./spell-check/edit-menu-spell-check-provider */ "ext_mod_id_1728986549046_30");
/* harmony import */ var _spell_check_editor_spell_check_provider__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./spell-check/editor-spell-check-provider */ "ext_mod_id_1728986549046_31");
/* harmony import */ var _sitefinity_images_sitefinity_images_toolbar_item_provider__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./sitefinity-images/sitefinity-images-toolbar-item-provider */ "ext_mod_id_1728986549046_32");










/**
 * The toolbar extender module.
 */
let EditorExtenderModule = class EditorExtenderModule {
};
EditorExtenderModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        providers: [
            _word_count_word_count_provider__WEBPACK_IMPORTED_MODULE_3__.WORD_COUNT_PROVIDER,
            _sitefinity_videos_sitefinity_videos_toolbar_item_provider__WEBPACK_IMPORTED_MODULE_4__.VIDEO_TOOLBAR_ITEM_PROVIDER,
            _switch_text_direction_switch_text_direction_provider__WEBPACK_IMPORTED_MODULE_5__.SWITCH_TEXT_DIRECTION_PROVIDER,
            _insert_symbol_insert_symbol_provider__WEBPACK_IMPORTED_MODULE_6__.INSERT_SYMBOL_PROVIDER,
            _spell_check_editor_spell_check_provider__WEBPACK_IMPORTED_MODULE_8__.EDITOR_SPELL_CHECK_PROVIDER,
            _spell_check_edit_menu_spell_check_provider__WEBPACK_IMPORTED_MODULE_7__.EDIT_MENU_SPELL_CHECK_PROVIDER,
            _sitefinity_images_sitefinity_images_toolbar_item_provider__WEBPACK_IMPORTED_MODULE_9__.IMAGE_TOOLBAR_ITEM_PROVIDER
        ],
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule
        ]
    })
], EditorExtenderModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_29":
/*!*************************************************************************!*\
  !*** ./samples/editor-extender/insert-symbol/insert-symbol.provider.ts ***!
  \*************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "INSERT_SYMBOL_PROVIDER": () => (/* binding */ INSERT_SYMBOL_PROVIDER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _symbol_list_insert_symbol_generator__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./symbol-list/insert-symbol-generator */ "ext_mod_id_1728986549046_67");
/* harmony import */ var _helpers_tool_builder__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../../helpers/tool-builder */ "ext_mod_id_1728986549046_69");
/* harmony import */ var _symbol_list_symbol_list_json__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./symbol-list/symbol-list.json */ "ext_mod_id_1728986549046_68");





const TOOLBAR_BUTTON_DATA = {
    DEFAULT: {
        name: "insertsymbol",
        tooltip: "Insert symbol"
    }
};
__webpack_require__(/*! !style-loader!css-loader!./insert-symbol.provider.css */ "ext_mod_id_1728986549046_76");

let InsertSymbolProvider = class InsertSymbolProvider {
    /**
     * If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
     * Otherwise return an empty array.
     * Example: return [ "embed" ];
     * The above code will remove the embed toolbar item from the editor.
     * Documentation where you can find all tools' names: https://docs.telerik.com/kendo-ui/api/javascript/ui/editor/configuration/tools
     *
     * @returns {string[]}
     * @memberof InsertSymbolProvider
     */
    getToolBarItemsNamesToRemove() {
        return [];
    }
    /**
     * This gives access to the Kendo UI Editor configuration object
     * that is used to initialize the editor upon creation
     * Kendo UI Editor configuration overview documentation -> https://docs.telerik.com/kendo-ui/controls/editors/editor/overview#configuration
     *
     * @param {*} configuration
     * @returns The modified configuration.
     * @memberof InsertSymbolProvider
     */
    configureEditor(configuration) {
        return configuration;
    }
    /**
     * The method that gets invoked when the editor constructs the toolbar actions.
     *
     * @param {*} editorHost The Kendo's editor object.
     * @returns {ToolBarItem[]} The custom toolbar items that will be added to the Kendo's toolbar.
     * @memberof InsertSymbolProvider
     */
    // eslint-disable-next-line  @typescript-eslint/no-unused-vars
    getToolBarItems(editorHost) {
        /**
         * The custom tool.
         */
        const DEFAULT_TOOL = {
            name: TOOLBAR_BUTTON_DATA.DEFAULT.name,
            tooltip: TOOLBAR_BUTTON_DATA.DEFAULT.tooltip,
            ordinal: -1,
            exec: () => { return; }
        };
        this.configureInsertSymbolTool();
        return [DEFAULT_TOOL];
    }
    configureInsertSymbolTool() {
        const buttonTemplate = kendo.ui.editor.EditorUtils.buttonTemplate;
        const NS = "kendoEditor";
        const popupTemplateGenerator = function () {
            const symbolGenerator = new _symbol_list_insert_symbol_generator__WEBPACK_IMPORTED_MODULE_3__.InsertSymbolGenerator(Object.keys(_symbol_list_symbol_list_json__WEBPACK_IMPORTED_MODULE_5__).map(k => _symbol_list_symbol_list_json__WEBPACK_IMPORTED_MODULE_5__[k]));
            const generatedHtml = symbolGenerator.generateHtml();
            return `<div class='k-ct-popup symbol-popup'><div class='k-status symbol-title'>INSERT SPECIAL CHARACTERS</div>${generatedHtml}</div>`;
        };
        const config = {
            _activate: function () {
                const that = this;
                const element = that.popup().element;
                element.autoApplyNS(NS).on("down", function (e) {
                    e.preventDefault();
                    const symbolCell = e.target;
                    const symbolValue = symbolCell.getAttribute(_symbol_list_insert_symbol_generator__WEBPACK_IMPORTED_MODULE_3__.DATA_ATTRIBUTE_NAME);
                    that._exec(symbolValue);
                });
            },
            _exec: function (sym) {
                // adds the chosen symbol to the editor
                this._editor.paste(sym);
                this._editor.trigger("change");
                this.popup().close();
            },
            _close: function () {
                this.popup().element.off("." + NS);
            }
        };
        const insertSymbolTool = _helpers_tool_builder__WEBPACK_IMPORTED_MODULE_4__.ToolBuilder.createPopupTool(kendo, TOOLBAR_BUTTON_DATA.DEFAULT.name, config, null, popupTemplateGenerator);
        _helpers_tool_builder__WEBPACK_IMPORTED_MODULE_4__.ToolBuilder.registerTool(kendo, insertSymbolTool, TOOLBAR_BUTTON_DATA.DEFAULT.name, buttonTemplate, true);
    }
};
InsertSymbolProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], InsertSymbolProvider);
const INSERT_SYMBOL_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.EDITOR_CONFIG_TOKEN,
    useClass: InsertSymbolProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_67":
/*!**************************************************************************************!*\
  !*** ./samples/editor-extender/insert-symbol/symbol-list/insert-symbol-generator.ts ***!
  \**************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "DATA_ATTRIBUTE_NAME": () => (/* binding */ DATA_ATTRIBUTE_NAME),
/* harmony export */   "InsertSymbolGenerator": () => (/* binding */ InsertSymbolGenerator)
/* harmony export */ });
const DATA_ATTRIBUTE_NAME = "data-value";
/**
 * Represents a helper class for importing a symbol list JSON and  generating html to populate the tool's popup.
 */
class InsertSymbolGenerator {
    constructor(symbolList) {
        this.symbolConfig = symbolList;
    }
    /**
     * Generates html from a JSON list of symbol models.
     */
    generateHtml() {
        let html = "";
        this.symbolConfig.forEach((symbol) => {
            html = html + this.generateCell(symbol);
        });
        return html;
    }
    generateCell(symbol) {
        return `<div class="symbol-cell" ${DATA_ATTRIBUTE_NAME}='${symbol.value}' title="${symbol.tooltip}">${symbol.value}</div>`;
    }
}
class SymbolModel {
}


/***/ }),

/***/ "ext_mod_id_1728986549046_32":
/*!**********************************************************************************************!*\
  !*** ./samples/editor-extender/sitefinity-images/sitefinity-images-toolbar-item-provider.ts ***!
  \**********************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "IMAGE_TOOLBAR_ITEM_PROVIDER": () => (/* binding */ IMAGE_TOOLBAR_ITEM_PROVIDER),
/* harmony export */   "ensureTrailingBreaks": () => (/* binding */ ensureTrailingBreaks)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



const TRAILING_BREAK = "<br class='k-br'>";
__webpack_require__(/*! !style-loader!css-loader!./sitefinity-images-toolbar-item-provider.css */ "ext_mod_id_1728986549046_75");
const ensureTrailingBreaks = (html) => {
    return `${TRAILING_BREAK}${html}${TRAILING_BREAK}`;
};
/**
 * A custom toolbar provider implementation for inserting existing images in the editor.
 * Kendo UI Editor custom tools documentation -> https://demos.telerik.com/kendo-ui/editor/custom-tools
 */
let ImagesToolbarItemProvider = class ImagesToolbarItemProvider {
    constructor(selectorService) {
        this.selectorService = selectorService;
    }
    getToolBarItems(editorHost) {
        const CUSTOM_TOOLBAR_ITEM = {
            name: "Sitefinity-images",
            tooltip: "Sitefinity images",
            ordinal: 7,
            exec: () => {
                const editor = editorHost.getKendoEditor();
                // Save editor's current range, so we can insert
                // later the HTML at this position.
                const currentRange = editor.getRange();
                const selectorOptions = {
                    multiple: true
                };
                // open the selector and subscribe to the result
                this.selectorService.openImageLibrarySelector(selectorOptions).subscribe(images => {
                    if (images.length) {
                        // Restore editor's saved position.
                        editor.selectRange(currentRange);
                        images.forEach((img) => {
                            const imageElement = document.createElement("img");
                            imageElement.src = img.data.ThumbnailUrl;
                            // Insert the HTML and trigger editor's change, so the
                            // HTML can be saved.
                            editor.paste(ensureTrailingBreaks(imageElement.outerHTML));
                            editor.trigger("change");
                        });
                    }
                });
            }
        };
        return [CUSTOM_TOOLBAR_ITEM];
    }
    getToolBarItemsNamesToRemove() {
        // If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
        // Otherwise return an empty array.
        // Example: return [ "embed" ];
        // The above code will remove the embed toolbar item from the editor.
        return [];
    }
};
ImagesToolbarItemProvider.ctorParameters = () => [
    { type: undefined, decorators: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_1__.Inject, args: [_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.SELECTOR_SERVICE,] }] }
];
ImagesToolbarItemProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)(),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [Object])
], ImagesToolbarItemProvider);
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const IMAGE_TOOLBAR_ITEM_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.TOOLBARITEMS_TOKEN,
    useClass: ImagesToolbarItemProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_28":
/*!**********************************************************************************************!*\
  !*** ./samples/editor-extender/sitefinity-videos/sitefinity-videos-toolbar-item-provider.ts ***!
  \**********************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "VIDEO_TOOLBAR_ITEM_PROVIDER": () => (/* binding */ VIDEO_TOOLBAR_ITEM_PROVIDER),
/* harmony export */   "ensureTrailingBreaks": () => (/* binding */ ensureTrailingBreaks)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



// This is webpack specific loader syntax for injecting css as <style> tag in header
__webpack_require__(/*! !style-loader!css-loader!./sitefinity-videos-toolbar-item-provider.css */ "ext_mod_id_1728986549046_73");
const TRAILING_BREAK = "<br class='k-br'>";
const ensureTrailingBreaks = (html) => {
    return `${TRAILING_BREAK}${html}${TRAILING_BREAK}`;
};
/**
 * A custom toolbar provider implementation for inserting existing videos in the editor.
 * Kendo UI Editor custom tools documentation -> https://demos.telerik.com/kendo-ui/editor/custom-tools
 */
let VideosToolbarItemProvider = class VideosToolbarItemProvider {
    constructor(selectorService) {
        this.selectorService = selectorService;
    }
    getToolBarItems(editorHost) {
        const CUSTOM_TOOLBAR_ITEM = {
            name: "Sitefinity-videos",
            tooltip: "Sitefinity videos",
            ordinal: 6,
            exec: () => {
                const editor = editorHost.getKendoEditor();
                // Save editor's current range, so we can insert
                // later the HTML at this position.
                const currentRange = editor.getRange();
                const selectorOptions = {
                    multiple: true
                };
                // open the selector and subscribe to the result
                this.selectorService.openVideoLibrarySelector(selectorOptions).subscribe(videos => {
                    if (videos.length) {
                        // Restore editor's saved position.
                        editor.selectRange(currentRange);
                        videos.forEach(video => {
                            const videoElement = document.createElement("video");
                            // Disable video playing, but show controls,
                            // so the video can be playable on the frontend.
                            videoElement.contentEditable = "false";
                            videoElement.src = video.url;
                            videoElement.setAttribute("controls", "true");
                            // Insert the HTML and trigger editor's change, so the
                            // HTML can be saved.
                            editor.paste(ensureTrailingBreaks(videoElement.outerHTML));
                            editor.trigger("change");
                        });
                    }
                });
            }
        };
        return [CUSTOM_TOOLBAR_ITEM];
    }
    getToolBarItemsNamesToRemove() {
        // If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
        // Otherwise return an empty array.
        // Example: return [ "embed" ];
        // The above code will remove the embed toolbar item from the editor.
        return [];
    }
};
VideosToolbarItemProvider.ctorParameters = () => [
    { type: undefined, decorators: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_1__.Inject, args: [_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.SELECTOR_SERVICE,] }] }
];
VideosToolbarItemProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)(),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [Object])
], VideosToolbarItemProvider);
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const VIDEO_TOOLBAR_ITEM_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.TOOLBARITEMS_TOKEN,
    useClass: VideosToolbarItemProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_30":
/*!*******************************************************************************!*\
  !*** ./samples/editor-extender/spell-check/edit-menu-spell-check-provider.ts ***!
  \*******************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "EDIT_MENU_SPELL_CHECK_PROVIDER": () => (/* binding */ EDIT_MENU_SPELL_CHECK_PROVIDER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



let EditMenuSpellCheckProvider = class EditMenuSpellCheckProvider {
    getButtons(element) {
        if (element instanceof HTMLSpanElement && element.attributes["suggestion"]) {
            const spellCheckButtons = this.createSpellCheckButtons(element);
            return spellCheckButtons;
        }
        return [];
    }
    createSpellCheckButtons(element) {
        const suggestion = element.attributes["suggestion"].value;
        const fakeWordButton = {
            name: "suggestion",
            action: null,
            text: `${suggestion}`,
            tooltip: `${suggestion}`,
            isActive: false,
            closeMenuOnClick: false
        };
        const acceptButton = {
            name: "check",
            action: () => {
                element.outerHTML = suggestion;
            },
            text: null,
            tooltip: "Accept correction",
            isActive: false,
            closeMenuOnClick: true
        };
        const cancelButton = {
            name: "times",
            action: () => {
                element.outerHTML = element.innerText;
            },
            text: null,
            tooltip: "Discard",
            isActive: false,
            closeMenuOnClick: true
        };
        return [
            new _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.EditMenuSection(fakeWordButton),
            new _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.EditMenuSection(acceptButton),
            new _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.EditMenuSection(cancelButton)
        ];
    }
};
EditMenuSpellCheckProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], EditMenuSpellCheckProvider);
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const EDIT_MENU_SPELL_CHECK_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.EDIT_MENU_TOKEN,
    useClass: EditMenuSpellCheckProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_31":
/*!****************************************************************************!*\
  !*** ./samples/editor-extender/spell-check/editor-spell-check-provider.ts ***!
  \****************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "EDITOR_SPELL_CHECK_PROVIDER": () => (/* binding */ EDITOR_SPELL_CHECK_PROVIDER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/common/http */ "ext_mod_id_1728986549046_49");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_angular_common_http__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1728986549046_52");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_4__);





// This is webpack specific loader syntax for injecting css as <style> tag in header
__webpack_require__(/*! !style-loader!css-loader!./editor-spell-check-provider.css */ "ext_mod_id_1728986549046_74");
/*
 * NOTE: Replace this example key with your subscription key.
 * For more information on how to get a key check here: https://azure.microsoft.com/en-us/services/cognitive-services/spell-check/
 */
const AZURE_LANGUAGE_SERVICES_API_KEY = "";
/**
 * Indicates the minimum value of certainty that is needed in order a correction to be applied.
 */
const MIN_CERTAINTY = 0.5;
const HOST = "https://api.cognitive.microsoft.com";
const PATH = "/bing/v7.0/spellcheck";
/**
 * Mode of spellcheck
 * Proof - Meant to provide Office Word like spelling corrections.
 *         It can correct long queries, provide casing corrections and suppresses aggressive corrections.
 * Spell - Meant to provide Search engine like spelling corrections.
 *         It will correct small queries(up to length 65 tokens) without any casing changes and
 *         will be more optimized (perf and relevance) towards search like queries.
 */
const PROOF_MODE = "proof";
const SPELL_MODE = "spell";
/**
 * Currently the proof mode supports only these 3 cultures. For other cultures spell mode should be used.
 * The list is subject to change.
 * For more information check: https://docs.microsoft.com/bg-bg/azure/cognitive-services/bing-spell-check/proof-text
 */
const proofModeCultures = [
    "en-US",
    "es-ES",
    "pt-BR"
];
/**
 * A custom toolbar provider implementation for checheking and correcting the spelling in the kendo editor.
 * Kendo UI Editor custom tools documentation -> https://demos.telerik.com/kendo-ui/editor/custom-tools
 */
let EditorSpellCheckProvider = class EditorSpellCheckProvider {
    constructor(http) {
        this.http = http;
    }
    /**
     * The method that gets invoked when the editor constructs the toolbar actions.
     * @param editorHost The instance of the editor.
     */
    getToolBarItems(editorHost) {
        const SPELL_CHECK_TOOLBAR_ITEM = {
            name: "Spell-check",
            tooltip: "Spell check",
            ordinal: -1,
            exec: () => this.spellCheck(editorHost, this.culture)
        };
        return [SPELL_CHECK_TOOLBAR_ITEM];
    }
    getToolBarItemsNamesToRemove() {
        /**
         * If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
         * Otherwise return an empty array.
         * Example: return [ "embed" ];
         * The above code will remove the embed toolbar item from the editor.
         * Documentation where you can find all tools' names: https://docs.telerik.com/kendo-ui/api/javascript/ui/editor/configuration/tools
         */
        return [];
    }
    /**
     * This gives access to the Kendo UI Editor configuration object
     * that is used to initialize the editor upon creation
     * Kendo UI Editor configuration Overiview documentation -> https://docs.telerik.com/kendo-ui/controls/editors/editor/overview#configuration
     */
    configureEditor(configuration) {
        this.culture = configuration.culture;
        return configuration;
    }
    spellCheck(editorHost, culture) {
        const editor = editorHost.getKendoEditor();
        let text = editor.value();
        const textWithoutHTMLTags = this.stripHTML(text);
        let batches = [{
                text: textWithoutHTMLTags,
                startIndex: 0
            }];
        let mode = PROOF_MODE;
        /*
        * NOTE: Spell mode will make a batch of queries.
        * There is a change your subscription plan does not support multiple queries per second.
        * In such case use proof mode.
        */
        if (culture && proofModeCultures.indexOf(culture) === -1) {
            mode = SPELL_MODE;
            batches = this.splitTextInBatches(textWithoutHTMLTags);
        }
        const requests = [];
        batches.forEach(batch => {
            requests.push(this.makeRequest(batch.text, culture, mode));
        });
        (0,rxjs__WEBPACK_IMPORTED_MODULE_4__.forkJoin)(requests).subscribe((responses) => {
            let lastMarkedErrorIndex = 0;
            responses.forEach((response, index) => {
                if (response._type === "SpellCheck") {
                    response.flaggedTokens.forEach(token => {
                        // find the token in the text
                        const indexOfMisspelledWord = text.indexOf(token.token, lastMarkedErrorIndex);
                        if (indexOfMisspelledWord < token.offset + batches[index].startIndex)
                            return;
                        if (token.suggestions.length <= 0)
                            return;
                        // get the best suggestion if over the min required certainty
                        const suggestion = token.suggestions[0].suggestion;
                        const certainty = token.suggestions[0].score;
                        if (certainty < MIN_CERTAINTY)
                            return;
                        const markedWord = document.createElement("SPAN");
                        markedWord.setAttribute("suggestion", suggestion);
                        markedWord.setAttribute("data-sf-ec-immutable", "");
                        markedWord.setAttribute("custom-edit-menu", "");
                        markedWord.innerText = token.token;
                        // check if word is already marked
                        const indexOfMarkedWord = text.indexOf(markedWord.outerHTML, lastMarkedErrorIndex);
                        if (indexOfMarkedWord !== -1 && indexOfMarkedWord < indexOfMisspelledWord)
                            return;
                        // apply the mark
                        text = text.slice(0, indexOfMisspelledWord)
                            + text.slice(indexOfMisspelledWord, indexOfMisspelledWord + token.token.length).replace(token.token, markedWord.outerHTML)
                            + text.slice(indexOfMisspelledWord + token.token.length);
                        // bump the counter of fixed words
                        lastMarkedErrorIndex = indexOfMisspelledWord + markedWord.outerHTML.length;
                    });
                    editor.value(text);
                    editor.trigger("change");
                }
            });
        }, (error) => {
            alert(`${error.error.message} Contact your administrator to resolve this issue.`);
        });
    }
    makeRequest(text, culture = "en-US", mode = "proof") {
        const queryString = "?mkt=" + culture + "&mode=" + mode;
        const url = HOST + PATH + queryString;
        const body = new URLSearchParams();
        body.set("text", text);
        const options = {
            headers: {
                "Ocp-Apim-Subscription-Key": AZURE_LANGUAGE_SERVICES_API_KEY,
                "Content-Type": "application/x-www-form-urlencoded"
            }
        };
        return this.http.post(url, body.toString(), options);
    }
    stripHTML(html) {
        const tmp = document.createElement("DIV");
        tmp.innerHTML = html;
        return tmp.textContent || tmp.innerText || "";
    }
    splitTextInBatches(text) {
        const batches = [];
        const words = text.split(" ");
        const batch = {
            text: "",
            startIndex: 0
        };
        let lastMarkedBatchIndex = 0;
        words.forEach(word => {
            const newBatchText = batch.text === "" ? word : batch.text + " " + word;
            if (newBatchText.length <= 65) {
                batch.text = newBatchText;
            }
            else {
                // find the batch in the text
                const indexOfBatch = text.indexOf(batch.text, lastMarkedBatchIndex);
                batch.startIndex = indexOfBatch;
                lastMarkedBatchIndex = indexOfBatch;
                batches.push(JSON.parse(JSON.stringify(batch)));
                batch.text = word;
            }
        });
        batches.push(batch);
        return batches;
    }
};
EditorSpellCheckProvider.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_3__.HttpClient }
];
EditorSpellCheckProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)(),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_3__.HttpClient])
], EditorSpellCheckProvider);
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const EDITOR_SPELL_CHECK_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.EDITOR_CONFIG_TOKEN,
    useClass: EditorSpellCheckProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_27":
/*!*****************************************************************************************!*\
  !*** ./samples/editor-extender/switch-text-direction/switch-text-direction.provider.ts ***!
  \*****************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "SWITCH_TEXT_DIRECTION_PROVIDER": () => (/* binding */ SWITCH_TEXT_DIRECTION_PROVIDER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1728986549046_52");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! rxjs/operators */ "ext_mod_id_1728986549046_65");
/* harmony import */ var rxjs_operators__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(rxjs_operators__WEBPACK_IMPORTED_MODULE_4__);





// These classes are defined in the application's styles.
const RTL_CLASS = "-sf-direction-rtl";
const LTR_CLASS = "-sf-direction-ltr";
const SELECTED_CLASS = "k-state-selected";
const LTR_BUTTON_SELECTOR = ".k-i-Left-to-right";
const RTL_BUTTON_SELECTOR = ".k-i-Right-to-left";
const KENDO_EDITOR_CLASS = "k-editor";
const SF_EDITOR_TAG_NAME = "sf-editor";
const EDIT_MENU_SELECTOR = "sf-edit-menu";
const TOOLBAR_BUTTONS_DATA = {
    LTR: {
        name: "Left-to-right",
        tooltip: "Left-to-right"
    },
    RTL: {
        name: "Right-to-left",
        tooltip: "Right-to-left"
    }
};
const arrowKeycodes = new Set([37, 38, 39, 40]);
var SelectionDirection;
(function (SelectionDirection) {
    SelectionDirection[SelectionDirection["topToBottom"] = 0] = "topToBottom";
    SelectionDirection[SelectionDirection["bottomToTop"] = 1] = "bottomToTop";
})(SelectionDirection || (SelectionDirection = {}));
__webpack_require__(/*! !style-loader!css-loader!./switch-text-direction.provider.css */ "ext_mod_id_1728986549046_72");
let SwitchTextDirectionProvider = class SwitchTextDirectionProvider {
    /**
     * The method that gets invoked when the editor constructs the toolbar actions.
     *
     * @param {*} editorHost The Kendo's editor object.
     * @returns {ToolBarItem[]} The custom toolbar items that will be added to the Kendo's toolbar.
     * @memberof SwitchTextDirectionProvider
     */
    getToolBarItems(editorHost) {
        this.handleCursorMove(editorHost);
        const SWITCH_LEFT_TO_RIGHT_TOOL = {
            name: TOOLBAR_BUTTONS_DATA.LTR.name,
            tooltip: TOOLBAR_BUTTONS_DATA.LTR.tooltip,
            ordinal: 6,
            exec: () => {
                const ltrButtonParent = jQuery(LTR_BUTTON_SELECTOR).parent()[0];
                this.handleExec(ltrButtonParent, editorHost, LTR_CLASS, () => this.handleButtonStylesOnLTRButtonClicked(editorHost));
            }
        };
        const SWITCH_RIGHT_TO_LEFT_TOOL = {
            name: TOOLBAR_BUTTONS_DATA.RTL.name,
            tooltip: TOOLBAR_BUTTONS_DATA.RTL.tooltip,
            ordinal: 7,
            exec: () => {
                const rtlButtonParent = jQuery(RTL_BUTTON_SELECTOR).parent()[0];
                this.handleExec(rtlButtonParent, editorHost, RTL_CLASS, () => this.handleButtonStylesOnRTLButtonClicked(editorHost));
            }
        };
        // Should group the direction buttons once the editor is loaded and focused.
        (0,rxjs__WEBPACK_IMPORTED_MODULE_3__.fromEvent)(editorHost[0], "focusin")
            .pipe((0,rxjs_operators__WEBPACK_IMPORTED_MODULE_4__.first)())
            .subscribe(() => {
            const toolbar = editorHost.getKendoEditor().toolbar.element;
            (0,_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.groupToolbarButtons)(toolbar, RTL_BUTTON_SELECTOR, LTR_BUTTON_SELECTOR, false);
        });
        return [SWITCH_LEFT_TO_RIGHT_TOOL, SWITCH_RIGHT_TO_LEFT_TOOL];
    }
    /**
     * If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
     * Otherwise return an empty array.
     * Example: return [ "embed" ];
     * The above code will remove the embed toolbar item from the editor.
     *
     * @returns {string[]}
     * @memberof SwitchTextDirectionProvider
     */
    getToolBarItemsNamesToRemove() {
        return [];
    }
    /**
     * This gives access to the Kendo UI Editor configuration object
     * that is used to initialize the editor upon creation
     * Kendo UI Editor configuration overview documentation -> https://docs.telerik.com/kendo-ui/controls/editors/editor/overview#configuration
     *
     * @param {*} configuration
     * @returns The modified configuration.
     * @memberof SwitchTextDirectionProvider
     */
    configureEditor(configuration) {
        return configuration;
    }
    /**
     * Finds the parent element of the one that is the caret on.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @returns {HTMLElement}
     * @memberof SwitchTextDirectionProvider
     */
    findParent(editorHost) {
        const editor = editorHost.getKendoEditor();
        let currentNode = editor.getRange().startContainer;
        if (currentNode.nodeName === "#text") {
            currentNode = currentNode.parentElement;
        }
        // When the editor returns itself as current element, we should find the first child
        // where the actual content is. The hierarchy is sf-editor -> div.k-editor -> actual content
        if (currentNode.tagName && currentNode.tagName.toLocaleLowerCase() === SF_EDITOR_TAG_NAME) {
            return currentNode.firstElementChild.firstElementChild;
        }
        while (this.isInlineElement(currentNode)) {
            currentNode = currentNode.parentElement;
        }
        // When the editor returns div.k-editor that means there isn't any formatting,
        // so we have to wrap the raw content in some element because otherwise we add
        // the class globally for the whole editor.
        if (currentNode.classList.contains(KENDO_EDITOR_CLASS)) {
            const wrapper = document.createElement("p");
            wrapper.innerHTML = currentNode.innerHTML;
            currentNode.innerHTML = "";
            currentNode.appendChild(wrapper);
            currentNode = wrapper;
        }
        return currentNode;
    }
    /**
     * Make the LTR button selected, and the RTL button unselected.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @memberof SwitchTextDirectionProvider
     */
    handleButtonStylesOnLTRButtonClicked(editorHost) {
        this.getToolbarButton(editorHost, LTR_BUTTON_SELECTOR).classList.add(SELECTED_CLASS);
        this.getToolbarButton(editorHost, RTL_BUTTON_SELECTOR).classList.remove(SELECTED_CLASS);
    }
    /**
     * Make the RTL button selected, and the LTR button unselected.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @memberof SwitchTextDirectionProvider
     */
    handleButtonStylesOnRTLButtonClicked(editorHost) {
        this.getToolbarButton(editorHost, RTL_BUTTON_SELECTOR).classList.add(SELECTED_CLASS);
        this.getToolbarButton(editorHost, LTR_BUTTON_SELECTOR).classList.remove(SELECTED_CLASS);
    }
    /**
     * Determines if the passed element has display: inline.
     *
     * @private
     * @param {HTMLElement} element The element which will be checked.
     * @returns True if the element is inline, otherwise false.
     * @memberof SwitchTextDirectionProvider
     */
    isInlineElement(element) {
        const style = getComputedStyle(element, "");
        return style.display === "inline";
    }
    /**
     * Retrieves toolbar button by given class.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @param {string} selector The selector for which the button will be queried.
     * @returns {HTMLElement}
     * @memberof SwitchTextDirectionProvider
     */
    getToolbarButton(editorHost, selector) {
        return editorHost
            .getKendoEditor()
            .toolbar
            .element[0]
            .querySelector(selector)
            .parentElement;
    }
    /**
     * When the caret's position is changed by clicking in the editor or
     * by navigating with the arrows, the toolbar's buttons should have
     * the correct selected state, depending on the direction of the element
     * on which the caret is.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @memberof SwitchTextDirectionProvider
     */
    handleCursorMove(editorHost) {
        const editorElement = editorHost[0];
        const toggleToolbarButtonsSelectedClasses = () => {
            let parent = this.findParent(editorHost);
            if (!parent) {
                return;
            }
            // When the parent doesn't have classes, this means it is just a kendo wrapper.
            if (!parent.classList.length) {
                parent = parent.parentElement;
            }
            if (parent.classList.contains(LTR_CLASS)) {
                this.handleButtonStylesOnLTRButtonClicked(editorHost);
            }
            else if (parent.classList.contains(RTL_CLASS) && !parent.classList.contains(KENDO_EDITOR_CLASS)) {
                this.handleButtonStylesOnRTLButtonClicked(editorHost);
            }
            else {
                this.turnOffSelectedButtons(editorHost);
            }
        };
        editorElement.addEventListener("click", () => toggleToolbarButtonsSelectedClasses());
        editorElement.addEventListener("keydown", (ev) => {
            if (arrowKeycodes.has(ev.keyCode)) {
                toggleToolbarButtonsSelectedClasses();
            }
            else if (!editorElement.textContent) {
                this.turnOffSelectedButtons(editorHost);
            }
        });
    }
    /**
     * When there is selection, all the selected nodes should have the specified
     * direction.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @param {string} classToAdd The class that should be added on each of the nodes that are in the selection.
     * @param {Function} doneCb Function that is called when the processing of the selection is done. It's called only when there is particular selection.
     * @returns {boolean}
     * @memberof SwitchTextDirectionProvider
     */
    tryHandleSelection(toolbarButton, editorHost, classToAdd, doneCb) {
        const selection = editorHost.getKendoEditor().getSelection();
        const selectionDirection = this.getSelectionDirection(selection);
        const baseNode = selection.baseNode || selection.anchorNode;
        if (!selection.isCollapsed && selection.focusNode !== baseNode) {
            let node = selection.focusNode;
            while (selection.containsNode(node)) {
                if (toolbarButton.classList.contains(SELECTED_CLASS)) {
                    this.removeDirection(toolbarButton, node.parentElement, classToAdd);
                }
                else {
                    this.setDirection(node.parentElement, classToAdd);
                }
                if (selectionDirection === SelectionDirection.topToBottom) {
                    if (!node.parentElement.previousElementSibling || !node.parentElement.previousElementSibling.firstChild) {
                        break;
                    }
                    node = node.parentElement.previousElementSibling.firstChild;
                }
                else {
                    if (!node.parentElement.nextElementSibling || !node.parentElement.nextElementSibling.firstChild) {
                        break;
                    }
                    node = node.parentElement.nextElementSibling.firstChild;
                }
            }
            doneCb();
            return true;
        }
        return false;
    }
    /**
     * Determines when the selections starts from top to bottom
     * or from bottom to top.
     *
     * @private
     * @param {*} selection Current selection.
     * @returns {SelectionDirection} Selection's direction.
     * @memberof SwitchTextDirectionProvider
     */
    getSelectionDirection(selection) {
        const focusNode = selection.focusNode;
        // Workaround for firefox. The selection API does not provide baseNode. The alternative is anchorNode.
        const baseNode = selection.baseNode || selection.anchorNode;
        const positionA = focusNode.compareDocumentPosition(baseNode);
        const positionB = baseNode.compareDocumentPosition(focusNode);
        const isBefore = positionB > positionA;
        if (isBefore) {
            return SelectionDirection.topToBottom;
        }
        return SelectionDirection.bottomToTop;
    }
    /**
     * Handles toolbar button click.
     *
     * @private
     * @param {*} toolbarButton kendo toolbar button for rtl or ltr direction.
     * @param {*} editorHost The Kendo's editor object.
     * @param {string} dirClassToAdd Text direction class that will be added to the current element or the elements in the selection.
     * @param {Function} applyButtonStyles Function that applies styles to the toolbar buttons.
     * @memberof SwitchTextDirectionProvider
     */
    handleExec(toolbarButton, editorHost, dirClassToAdd, applyButtonStyles) {
        jQuery(EDIT_MENU_SELECTOR).hide();
        if (!this.tryHandleSelection(toolbarButton, editorHost, dirClassToAdd, () => applyButtonStyles())) {
            const elementContainer = this.findParent(editorHost);
            if (toolbarButton.classList.contains(SELECTED_CLASS)) {
                this.removeDirection(toolbarButton, elementContainer, dirClassToAdd);
            }
            else {
                this.setDirection(elementContainer, dirClassToAdd);
                applyButtonStyles();
            }
        }
    }
    /**
     * Returns toolbar buttons to their normal state.
     *
     * @private
     * @param {*} editorHost The Kendo's editor object.
     * @memberof SwitchTextDirectionProvider
     */
    turnOffSelectedButtons(editorHost) {
        this.getToolbarButton(editorHost, LTR_BUTTON_SELECTOR).classList.remove(SELECTED_CLASS);
        this.getToolbarButton(editorHost, RTL_BUTTON_SELECTOR).classList.remove(SELECTED_CLASS);
    }
    /**
     * Checks desired text direction and sets required styles.
     *
     * @private
     * @param {*} elementToStyle the element that has to be styled.
     * @param {*} classToAdd RTL or LTR class to be added to the element.
     * @memberof SwitchTextDirectionProvider
     */
    setDirection(elementToStyle, classToAdd) {
        if (classToAdd === RTL_CLASS) {
            this.setDirectionStyles(elementToStyle, LTR_CLASS, "rtl", "right", RTL_CLASS);
        }
        else {
            this.setDirectionStyles(elementToStyle, RTL_CLASS, "ltr", "left", LTR_CLASS);
        }
    }
    /**
     * Removes text direction styles.
     *
     * @private
     * @param {*} toolbarButton kendo toolbar button for rtl or ltr direction.
     * @param {*} elementToStyle the element that has to be styled.
     * @param {*} classToRemove RTL or LTR class to be removed to the element.
     * @memberof SwitchTextDirectionProvider
     */
    removeDirection(toolbarButton, elementToStyle, classToRemove) {
        this.setDirectionStyles(elementToStyle, classToRemove, null, null);
        toolbarButton.classList.remove(SELECTED_CLASS);
    }
    /**
     * Sets required styles for text direction.
     *
     * @private
     * @param {*} elementToStyle the element that has to be styled.
     * @param {*} classToAdd RTL or LTR class to be added to the element.
     * @param {*} classToRemove RTL or LTR class to be removed from the element.
     * @param {*} directionStyle rtl or ltr css direction property value to be set to the element.
     * @param {*} alignmentStyle right or left css text-align property value to be set to the element.
     * @memberof SwitchTextDirectionProvider
     */
    setDirectionStyles(elementToStyle, classToRemove, directionStyle, alignmentStyle, classToAdd) {
        elementToStyle.classList.remove(classToRemove);
        if (classToAdd) {
            elementToStyle.classList.add(classToAdd);
        }
        elementToStyle.style.direction = directionStyle;
        elementToStyle.style.textAlign = alignmentStyle;
    }
};
SwitchTextDirectionProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], SwitchTextDirectionProvider);
const SWITCH_TEXT_DIRECTION_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.TOOLBARITEMS_TOKEN,
    useClass: SwitchTextDirectionProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_26":
/*!*******************************************************************!*\
  !*** ./samples/editor-extender/word-count/word-count-provider.ts ***!
  \*******************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "WORD_COUNT_PROVIDER": () => (/* binding */ WORD_COUNT_PROVIDER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



// This is webpack specific loader syntax for injecting css as <style> tag in header
__webpack_require__(/*! !style-loader!css-loader!./editor-config-provider.css */ "ext_mod_id_1728986549046_71");
/**
 * A custom toolbar provider implementation for counting the words in the html editor.
 * Kendo UI Editor custom tools documentation -> https://demos.telerik.com/kendo-ui/editor/custom-tools
 */
let WordCountProvider = class WordCountProvider {
    /**
     * The method that gets invoked when the editor constructs the toolbar actions.
     * @param editorHost The instance of the editor.
     */
    getToolBarItems(editorHost) {
        const wordsCount = () => {
            const editor = editorHost.getKendoEditor();
            const editorValue = this.stripHTML(editor.value());
            const count = editorValue ? editorValue.split(" ").length : 0;
            alert(`Words count: ${count}`);
        };
        /**
         * A custom toolbar item
         */
        const CUSTOM_TOOLBAR_ITEM = {
            name: "Words-count",
            tooltip: "Words count",
            ordinal: 5,
            exec: wordsCount
        };
        return [CUSTOM_TOOLBAR_ITEM];
    }
    getToolBarItemsNamesToRemove() {
        /**
         * If you want to remove some toolbar items return their names as strings in the array. Order is insignificant.
         * Otherwise return an empty array.
         * Example: return [ "embed" ];
         * The above code will remove the embed toolbar item from the editor.
         * Documentation where you can find all tools' names: https://docs.telerik.com/kendo-ui/api/javascript/ui/editor/configuration/tools
         */
        return [];
    }
    /**
     * This gives access to the Kendo UI Editor configuration object
     * that is used to initialize the editor upon creation
     * Kendo UI Editor configuration overview documentation -> https://docs.telerik.com/kendo-ui/controls/editors/editor/overview#configuration
     */
    configureEditor(configuration) {
        configuration.pasteCleanup.span = false;
        return configuration;
    }
    stripHTML(html) {
        const tmp = document.createElement("DIV");
        tmp.innerHTML = html;
        return tmp.textContent || tmp.innerText || "";
    }
};
WordCountProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], WordCountProvider);
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const WORD_COUNT_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.EDITOR_CONFIG_TOKEN,
    useClass: WordCountProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_7":
/*!****************************************!*\
  !*** ./samples/fields-change/index.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "FieldsChangeModule": () => (/* binding */ FieldsChangeModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _news_field_change_service__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./news-field-change.service */ "ext_mod_id_1728986549046_15");



let FieldsChangeModule = class FieldsChangeModule {
};
FieldsChangeModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        providers: [
            _news_field_change_service__WEBPACK_IMPORTED_MODULE_2__.NEWS_FIELDS_CHANGE_PROVIDER
        ]
    })
], FieldsChangeModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_15":
/*!************************************************************!*\
  !*** ./samples/fields-change/news-field-change.service.ts ***!
  \************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "NEWS_FIELDS_CHANGE_PROVIDER": () => (/* binding */ NEWS_FIELDS_CHANGE_PROVIDER),
/* harmony export */   "NewsFieldsChangeService": () => (/* binding */ NewsFieldsChangeService)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_2__);



const NEWS_TYPE_FULL_NAME = "Telerik.Sitefinity.News.Model.NewsItem";
const TITLE_FIELD_NAME = "Title";
const RITCH_TEXT_EDITOR_FIELD_NAME = "Content";
/**
 * Service which listens for field changes for news items.
 *
 * @export
 * @class NewsFieldsChangeService
 * @implements {FieldChangeService}
 */
let NewsFieldsChangeService = class NewsFieldsChangeService {
    /**
     * Method called on every field change.
     *
     * @param {string} changedFieldName The name of the field that was changed.
     * @param {*} changedValue The new value of the field.
     * @param {FieldWrapper[]} fields All fields in the form.
     * @memberof FieldsChangeService
     */
    processChange(changedFieldName, changedValue, fields) {
        // When the title field is changed, we want to update the long text field with the same value(mirroring).
        if (changedFieldName === TITLE_FIELD_NAME) {
            const ritchTextEditorField = fields.find(x => x.fieldModel.key === RITCH_TEXT_EDITOR_FIELD_NAME);
            ritchTextEditorField.writeValue(changedValue);
        }
    }
    /**
     * Determines whether the service can process field changes for a certain content type.
     *
     * @param {string} typeFullName The CLR full name of the item(ex: Telerik.Sitefinity.News.Model.NewsItem)
     * @returns {boolean} A value indicating whether the service can process field changes.
     * @memberof FieldsChangeService
     */
    canProcess(typeFullName) {
        return typeFullName === NEWS_TYPE_FULL_NAME;
    }
};
NewsFieldsChangeService = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_2__.Injectable)()
], NewsFieldsChangeService);

const NEWS_FIELDS_CHANGE_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_1__.FIELDS_CHANGE_SERVICE_TOKEN,
    useClass: NewsFieldsChangeService
};


/***/ }),

/***/ "ext_mod_id_1728986549046_12":
/*!***************************************************!*\
  !*** ./samples/grid-extender/columns-provider.ts ***!
  \***************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "COLUMNS_PROVIDER": () => (/* binding */ COLUMNS_PROVIDER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1728986549046_52");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _image_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./image.component */ "ext_mod_id_1728986549046_13");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_4__);





const COLUMN_TO_REMOVE = "LastModified";
/**
 * The index provider provides the custom columns back to the AdminApp.
 */
let DynamicItemIndexColumnsProvider = class DynamicItemIndexColumnsProvider {
    constructor() {
        this.columnName = "image3";
        this.columnTitle = "Image";
    }
    /**
     * This method gets invoked by the AdminApp when the columns from all of the providers are needed.
     * @param entityData Provides metadata for the current type.
     */
    // eslint-disable-next-line  @typescript-eslint/no-unused-vars
    getColumns(entityData) {
        // return the column model
        const column = {
            name: this.columnName,
            title: this.columnTitle,
            ordinal: 50,
            // The componentData object holds the type of component to initialize
            // properties can be passed as well. They will be set on the component once it is initialized.
            componentData: {
                type: _image_component__WEBPACK_IMPORTED_MODULE_3__.ImageComponent
            }
        };
        // return an observable here, because this might be a time consuming operation
        return (0,rxjs__WEBPACK_IMPORTED_MODULE_1__.of)([column]);
    }
    /**
     * Gets an obaservable collection of columns to be removed.
     * @param {EntityData} entityData Provides metadata for the current type.
     * @returns {Observable<string[]>} The columns which should be removed.
     * @memberof DynamicItemIndexColumnsProvider
     */
    // eslint-disable-next-line  @typescript-eslint/no-unused-vars
    getColumnsToRemove(entityData) {
        return (0,rxjs__WEBPACK_IMPORTED_MODULE_1__.of)([COLUMN_TO_REMOVE]);
    }
};
DynamicItemIndexColumnsProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_4__.Injectable)()
], DynamicItemIndexColumnsProvider);
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const COLUMNS_PROVIDER = {
    useClass: DynamicItemIndexColumnsProvider,
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.COLUMNS_TOKEN
};


/***/ }),

/***/ "ext_mod_id_1728986549046_13":
/*!**************************************************!*\
  !*** ./samples/grid-extender/image.component.ts ***!
  \**************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ImageComponent": () => (/* binding */ ImageComponent)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _image_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./image.component.html?ngResource */ "ext_mod_id_1728986549046_53");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common/http */ "ext_mod_id_1728986549046_49");
/* harmony import */ var _angular_common_http__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_common_http__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var rxjs_internal_operators_map__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! rxjs/internal/operators/map */ "ext_mod_id_1728986549046_51");
/* harmony import */ var rxjs_internal_operators_map__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(rxjs_internal_operators_map__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _image_data_json__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./image-data.json */ "ext_mod_id_1728986549046_37");






// Get a collection with images in base64 format from image-data.json file

/**
 * A custom component to be displayed in each cell in a specific column in the grid.
 */
let ImageComponent = class ImageComponent {
    /**
     * Initializes a new instance of the ImageComponent.
     * @param http - The http client service used for making http requests.
     */
    constructor(http) {
        this.http = http;
        // Sample height of the image
        this.imageHeight = 50;
    }
    ngOnInit() {
        this.imageSource = this.getSampleImageFromJSON();
        // To display a related image comment the line above and uncomment the line below.
        // NOTE: relatedImageFieldName variable should be assigned by the name of the related image field
        // this.getRelatedImageSource().subscribe(imageSource => this.imageSource = imageSource);
    }
    /**
     * Gets a related image source.
     * @returns {Observable<string>} The image source.
     */
    getRelatedImageSource() {
        // Replace the value with the related image field name
        const relatedImageFieldName = "_REPLACE_WITH_RELATED_IMAGE_FIELD_NAME_";
        // http prefix is dynamically replaced with the actual url of sitefinity
        const url = `${_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__.HTTP_PREFIX}/sf/system/${this.context.dataItem.metadata.setName}(${this.context.dataItem.key})/${relatedImageFieldName}`
            + (this.context.dataItem.provider ? `?sf_provider=${this.context.dataItem.provider}` : ``);
        return this.http.get(url).pipe((0,rxjs_internal_operators_map__WEBPACK_IMPORTED_MODULE_5__.map)((response) => {
            return response.value.length ? response.value[0].Url : "";
        }));
    }
    /**
     * Gets a random image source from some predefined values.
     * @returns {string} The image source.
     */
    getSampleImageFromJSON() {
        // Get a random image index from imageData
        const randomNumber = this.getRandomInt(0, _image_data_json__WEBPACK_IMPORTED_MODULE_6__.images.length);
        // Get this image's source for rendering
        return _image_data_json__WEBPACK_IMPORTED_MODULE_6__.images[randomNumber].source;
    }
    /**
     * Returns a random number between min (inclusive) and max (exclusive).
     * @param {number} min - Output number lower boundary.
     * @param {number} max - Output number upper boundary.
     * @returns {number} The generated random number.
     */
    getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min)) + min;
    }
};
ImageComponent.ctorParameters = () => [
    { type: _angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpClient }
];
ImageComponent = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_3__.Component)({
        template: _image_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__
    }),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [_angular_common_http__WEBPACK_IMPORTED_MODULE_2__.HttpClient])
], ImageComponent);



/***/ }),

/***/ "ext_mod_id_1728986549046_1":
/*!****************************************!*\
  !*** ./samples/grid-extender/index.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "GridExtenderModule": () => (/* binding */ GridExtenderModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _image_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./image.component */ "ext_mod_id_1728986549046_13");
/* harmony import */ var _columns_provider__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./columns-provider */ "ext_mod_id_1728986549046_12");




/**
 * The grid extender module.
 */
let GridExtenderModule = class GridExtenderModule {
};
GridExtenderModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        declarations: [
            _image_component__WEBPACK_IMPORTED_MODULE_2__.ImageComponent
        ],
        providers: [
            _columns_provider__WEBPACK_IMPORTED_MODULE_3__.COLUMNS_PROVIDER
        ]
    })
], GridExtenderModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_69":
/*!*****************************************!*\
  !*** ./samples/helpers/tool-builder.ts ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ToolBuilder": () => (/* binding */ ToolBuilder)
/* harmony export */ });
/**
 * Provides an interface for creating and registering custom tools in the Kendo editor.
 */
class ToolBuilder {
    /**
     * Creates a custom tool that extends the default Kendo popup tool with given configuration.
     * @param kendo Reference to the global kendo script
     * @param toolTitle The title to be used for the tool
     * @param config Configuration object that holds the needed functionality
     * @param command Command name
     * @param popupTemplateGenerator Popup template generator function
     */
    static createPopupTool(kendo, toolTitle, config, command, popupTemplateGenerator) {
        const PopupTool = kendo.ui.editor.PopupTool;
        const defaultConfig = {
            init: function (options) {
                if (config.init) {
                    config.init.bind(this)();
                }
                PopupTool.fn.init.call(this, jQuery.extend(options, {
                    command: command,
                    popupTemplate: popupTemplateGenerator.bind(this)()
                }));
            },
            _open: function () {
                PopupTool.fn._open.call(this);
                if (config._open) {
                    config._open.bind(this)();
                }
            },
            _close: function () {
                PopupTool.fn._close.call(this);
                if (config._close) {
                    config._close.bind(this)();
                }
            }
        };
        for (const functionName in config) {
            if (functionName === "init" || functionName === "_open" || functionName === "_close") {
                continue;
            }
            defaultConfig[functionName] = config[functionName];
        }
        return PopupTool.extend(defaultConfig);
    }
    /**
     * Registers a new custom tool in the Kendo editor, to be inserted later in the toolbar.
     * @param kendo Reference to the global Kendo script
     * @param Tool The generated tool
     * @param toolTitle The title of the tool
     * @param toolTemplate Template for the tool's appearance in the toolbar
     * @param isPopup Whether the tool is a popup or not
     */
    static registerTool(kendo, Tool, toolTitle, toolTemplate, isPopup = false) {
        const EditorUtils = kendo.ui.editor.EditorUtils;
        const ToolTemplate = kendo.ui.editor.ToolTemplate;
        EditorUtils.registerTool(toolTitle, new Tool({
            template: new ToolTemplate({
                template: toolTemplate,
                popup: isPopup,
                title: toolTitle
            })
        }));
    }
}


/***/ }),

/***/ "ext_mod_id_1728986549046_5":
/*!****************************************!*\
  !*** ./samples/item-extender/index.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ItemExtenderModule": () => (/* binding */ ItemExtenderModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _item_hooks_provider__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./item-hooks-provider */ "ext_mod_id_1728986549046_14");



/**
 * The grid extender module.
 */
let ItemExtenderModule = class ItemExtenderModule {
};
ItemExtenderModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        providers: [
            _item_hooks_provider__WEBPACK_IMPORTED_MODULE_2__.ITEM_HOOKS_PROVIDER
        ]
    })
], ItemExtenderModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_14":
/*!******************************************************!*\
  !*** ./samples/item-extender/item-hooks-provider.ts ***!
  \******************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ITEM_HOOKS_PROVIDER": () => (/* binding */ ITEM_HOOKS_PROVIDER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1728986549046_52");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3__);




let CustomItemHooksProvider = class CustomItemHooksProvider {
    onItemLoaded(item) {
        if (item.data) {
            console.log(`Item is loaded: ${item.data.Title}`);
        }
        else {
            console.log(`A new item is being created`);
        }
    }
    onEditItemChanged(data) {
        var _a, _b;
        return this.executeOperation(`Item changed: ${((_b = (_a = data.item) === null || _a === void 0 ? void 0 : _a.data) === null || _b === void 0 ? void 0 : _b.Title) || "No item"}`);
    }
    onEditItemInitializing(data) {
        var _a, _b;
        return this.executeOperation(`Item initializing: ${((_b = (_a = data.item) === null || _a === void 0 ? void 0 : _a.data) === null || _b === void 0 ? void 0 : _b.Title) || "No item"}`);
    }
    onEditItemUnloading(data) {
        var _a, _b;
        return this.executeOperation(`Item unloading: ${((_b = (_a = data.item) === null || _a === void 0 ? void 0 : _a.data) === null || _b === void 0 ? void 0 : _b.Title) || "No item"}`);
    }
    afterEditItemInit(data) {
        var _a, _b;
        return this.executeOperation(`After edit item init: ${((_b = (_a = data.item) === null || _a === void 0 ? void 0 : _a.data) === null || _b === void 0 ? void 0 : _b.Title) || "No item"}`);
    }
    onGridItemsChanged(data) {
        var _a;
        return this.executeOperation(`Grid items changing: ${((_a = data.items) === null || _a === void 0 ? void 0 : _a.length) ? data.items.map(x => x.data.Title) : "No items"}`);
    }
    onGridItemsInitializing(data) {
        var _a;
        return this.executeOperation(`Grid items initializing: ${((_a = data.items) === null || _a === void 0 ? void 0 : _a.length) ? data.items.map(x => x.data.Title) : "No items"}`);
    }
    onGridItemsUnloading(data) {
        var _a;
        return this.executeOperation(`Grid items unloading: ${((_a = data.items) === null || _a === void 0 ? void 0 : _a.length) ? data.items.map(x => x.data.Title) : "No items"}`);
    }
    afterGridInit(data) {
        var _a;
        return this.executeOperation(`After grid init: ${((_a = data.items) === null || _a === void 0 ? void 0 : _a.length) ? data.items.map(x => x.data.Title) : "No items"}`);
    }
    executeOperation(message) {
        const result$ = new rxjs__WEBPACK_IMPORTED_MODULE_2__.ReplaySubject();
        console.log(message);
        result$.next();
        return result$.asObservable();
    }
};
CustomItemHooksProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], CustomItemHooksProvider);
/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const ITEM_HOOKS_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_3__.ITEM_HOOKS_PROVIDER_TOKEN,
    useClass: CustomItemHooksProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_36":
/*!************************************************************************!*\
  !*** ./samples/library-extender/dam/custom-cloudinary-dam-provider.ts ***!
  \************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CUSTOM_CLOUDINARY_DAM_PROVIDER": () => (/* binding */ CUSTOM_CLOUDINARY_DAM_PROVIDER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);



const CUSTOM_MEDIA_CANNOT_BE_LOADED = "Custom media selector cannot be loaded.";
const CLOUDINARY_PROVIDER_TYPE_NAME = "CloudinaryBlobStorageProvider";
const CLOUDINARY_ID_QUERY_PARAM = "sf_cl_id";
const CLOUDINARY_VERSION_QUERY_PARAM = "sf_cl_version";
// example implementation for custom provider based on Cloudinary
let CustomCloudinaryDamProvider = class CustomCloudinaryDamProvider extends _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.DamProviderBase {
    constructor(zone) {
        super(zone);
    }
    isSupported(providerTypeName) {
        // validate the configured provider name equals with the custom implemented
        return providerTypeName === CLOUDINARY_PROVIDER_TYPE_NAME;
    }
    loadMediaSelector(damWrapper, mediaEntityData, allowMultiSelect) {
        // first validate the settings coming from the server
        if (!this.areSettingsPropertiesValid()) {
            this.error(CUSTOM_MEDIA_CANNOT_BE_LOADED);
            return;
        }
        this.loadDynamicScript(this.getPropertyValue("ScriptUrl")).subscribe(() => {
            // if script is loaded successfully 'cloudinary' variable must be initialized
            if (typeof cloudinary === "undefined") {
                this.error(CUSTOM_MEDIA_CANNOT_BE_LOADED);
                return;
            }
            // create configuration specific for Cloudinary
            const config = {
                cloud_name: this.getPropertyValue("CloudName"),
                api_key: this.getPropertyValue("ApiKey"),
                multiple: allowMultiSelect,
                inline_container: `.${damWrapper.className.replace(/\s/g, ".")}`,
                remove_header: true,
                integration: {
                    type: "custom_progress_sitefinity_connector_for_cloudinary",
                    platform: "admin app extensions",
                    version: "1.0",
                    environment: null
                }
            };
            const handlers = {
                insertHandler: this.insertHandler.bind(this),
                errorHandler: this.error.bind(this)
            };
            try {
                // instantiate and open widget
                cloudinary.openMediaLibrary(config, handlers);
            }
            catch (error) {
                this.error(error);
            }
        }, () => {
            this.error(CUSTOM_MEDIA_CANNOT_BE_LOADED);
        });
    }
    insertHandler(data) {
        this.mediaSelected();
        const damAssets = [];
        if (data.assets) {
            data.assets.forEach(asset => {
                // convert selected DAM assets to DamAsset interface
                const damAsset = this.getDamAsset(asset);
                damAssets.push(damAsset);
            });
            // pass converted assets to base class
            this.assetsSelected(damAssets);
        }
        else {
            this.error("FAILED_TO_INSERT_MEDIA_ASSET");
        }
    }
    areSettingsPropertiesValid() {
        const cloudName = this.getPropertyValue("CloudName");
        if (!cloudName) {
            return false;
        }
        const scriptUrl = this.getPropertyValue("ScriptUrl");
        if (!scriptUrl) {
            return false;
        }
        const apiKey = this.getPropertyValue("ApiKey");
        if (!apiKey) {
            return false;
        }
        return true;
    }
    getDamAsset(asset) {
        const slashIndex = asset.public_id.lastIndexOf("/");
        let title = asset.public_id.substring(slashIndex + 1);
        asset.format = asset.format || this.getExtensionFromFileName(title);
        title = this.getFileNameWithoutExtension(title);
        let url = asset.secure_url;
        if (asset.derived && asset.derived.length) {
            url = asset.derived[0].secure_url;
            asset.format = this.getExtensionFromFileName(url) || asset.format;
        }
        const appendSymbol = url.indexOf("?") === -1 ? "?" : "&";
        url += `${appendSymbol}${CLOUDINARY_ID_QUERY_PARAM}=${asset.public_id}&${CLOUDINARY_VERSION_QUERY_PARAM}=${asset.version}`;
        const damAsset = {
            title: title,
            mimeType: null,
            extension: `.${asset.format}`,
            width: Math.floor(asset.width) || null,
            height: Math.floor(asset.height) || null,
            size: Math.floor(asset.bytes),
            url: url
        };
        return damAsset;
    }
    getExtensionFromFileName(fileName) {
        const nameArray = fileName.split(".");
        if (nameArray.length > 1) {
            return nameArray.pop();
        }
        return "";
    }
    getFileNameWithoutExtension(fileName) {
        const nameArray = fileName.split(".");
        if (nameArray && nameArray.length) {
            return nameArray[0];
        }
        return fileName;
    }
};
CustomCloudinaryDamProvider.ctorParameters = () => [
    { type: _angular_core__WEBPACK_IMPORTED_MODULE_1__.NgZone }
];
CustomCloudinaryDamProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)(),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgZone])
], CustomCloudinaryDamProvider);
const CUSTOM_CLOUDINARY_DAM_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.DAM_PROVIDER_TOKEN,
    useClass: CustomCloudinaryDamProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_11":
/*!*******************************************!*\
  !*** ./samples/library-extender/index.ts ***!
  \*******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "LibraryExtenderModule": () => (/* binding */ LibraryExtenderModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "ext_mod_id_1728986549046_47");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_common__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _dam_custom_cloudinary_dam_provider__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./dam/custom-cloudinary-dam-provider */ "ext_mod_id_1728986549046_36");




/**
 * The Lib extender module.
 */
let LibraryExtenderModule = class LibraryExtenderModule {
};
LibraryExtenderModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        providers: [
            _dam_custom_cloudinary_dam_provider__WEBPACK_IMPORTED_MODULE_3__.CUSTOM_CLOUDINARY_DAM_PROVIDER
        ],
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule
        ]
    })
], LibraryExtenderModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_6":
/*!********************************!*\
  !*** ./samples/theme/index.ts ***!
  \********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "ThemeModule": () => (/* binding */ ThemeModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/common */ "ext_mod_id_1728986549046_47");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_common__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _theme_provider__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./theme-provider */ "ext_mod_id_1728986549046_33");




let ThemeModule = class ThemeModule {
};
ThemeModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        providers: [
            _theme_provider__WEBPACK_IMPORTED_MODULE_3__.SAMPLE_THEME_PROVIDER
        ],
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_2__.CommonModule
        ]
    })
], ThemeModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_33":
/*!*****************************************!*\
  !*** ./samples/theme/theme-provider.ts ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "SAMPLE_THEME_PROVIDER": () => (/* binding */ SAMPLE_THEME_PROVIDER)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_provider__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1/theme/theme-provider */ "ext_mod_id_1728986549046_60");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_provider__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_provider__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1/theme/theme-variables */ "ext_mod_id_1728986549046_61");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__);




let SampleThemeProvider = class SampleThemeProvider {
    constructor() {
        // #region Sample theme variables
        this.sampleThemeVariables = [{
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.DefaultButtonBorderColor,
                value: "#333"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.DefaultButtonBackgroundColor,
                value: "#FFF"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.DefaultButtonColor,
                value: "#000"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.DefaultButtonInteractionBorderColor,
                value: "#E4E4E4"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.DefaultButtonInteractionBackgroundColor,
                value: "#E4E4E4"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.DefaultButtonInteractionColor,
                value: "#333"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.DefaultButtonDisabledBorderColor,
                value: "#C2C2C2"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.DeleteButtonDisabledBackgroundColor,
                value: "#FFF"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.DefaultButtonDisabledColor,
                value: "#C2C2C2"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.ActionButtonBorderColor,
                value: "#006CD9"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.ActionButtonBackgroundColor,
                value: "#006CD9"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.ActionButtonColor,
                value: "#FFF"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.ActionButtonInteractionBorderColor,
                value: "#0053C0"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.ActionButtonInteractionBackgroundColor,
                value: "#0053C0"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.ActionButtonInteractionColor,
                value: "#FFF"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.ActionButtonDisabledBorderColor,
                value: "#BFD4F3"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.ActionButtonDisabledBackgroundColor,
                value: "#BFD4F3"
            }, {
                key: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_variables__WEBPACK_IMPORTED_MODULE_3__.ThemeVariables.ActionButtonDisabledColor,
                value: "#FFF"
            }];
        // #endregion
        this.themes = [{
                name: "Sample",
                themeVariables: this.sampleThemeVariables
            }];
    }
    getThemes() {
        return this.themes;
    }
};
SampleThemeProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], SampleThemeProvider);
const SAMPLE_THEME_PROVIDER = {
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1_theme_theme_provider__WEBPACK_IMPORTED_MODULE_2__.THEME_TOKEN,
    useClass: SampleThemeProvider
};


/***/ }),

/***/ "ext_mod_id_1728986549046_9":
/*!********************************************!*\
  !*** ./samples/tree/related-data/index.ts ***!
  \********************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "RelatedDateExtenderModule": () => (/* binding */ RelatedDateExtenderModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/common */ "ext_mod_id_1728986549046_47");
/* harmony import */ var _angular_common__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_common__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _related_data_custom_tree_node_component_provider__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./related-data-custom-tree-node-component-provider */ "ext_mod_id_1728986549046_34");
/* harmony import */ var _related_data_custom_component__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./related-data-custom.component */ "ext_mod_id_1728986549046_35");





let RelatedDateExtenderModule = class RelatedDateExtenderModule {
};
RelatedDateExtenderModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_2__.NgModule)({
        declarations: [
            _related_data_custom_component__WEBPACK_IMPORTED_MODULE_4__.RelatedDataCustomComponent
        ],
        providers: [
            _related_data_custom_tree_node_component_provider__WEBPACK_IMPORTED_MODULE_3__.CUSTOM_TREE_COMPONENT_PROVIDER,
            _angular_common__WEBPACK_IMPORTED_MODULE_1__.DatePipe
        ],
        imports: [
            _angular_common__WEBPACK_IMPORTED_MODULE_1__.CommonModule
        ]
    })
], RelatedDateExtenderModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_34":
/*!***************************************************************************************!*\
  !*** ./samples/tree/related-data/related-data-custom-tree-node-component-provider.ts ***!
  \***************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CUSTOM_TREE_COMPONENT_PROVIDER": () => (/* binding */ CUSTOM_TREE_COMPONENT_PROVIDER),
/* harmony export */   "RelatedDataTreeNodeComponentProvider": () => (/* binding */ RelatedDataTreeNodeComponentProvider)
/* harmony export */ });
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_tree__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1/tree */ "ext_mod_id_1728986549046_62");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_tree__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1_tree__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_tree_custom_tree_node_component_features__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1/tree/custom-tree-node-component-features */ "ext_mod_id_1728986549046_63");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_tree_custom_tree_node_component_features__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1_tree_custom_tree_node_component_features__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _related_data_custom_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./related-data-custom.component */ "ext_mod_id_1728986549046_35");



class RelatedDataTreeNodeComponentProvider {
    getComponentData(feature, entitySet) {
        if (feature === _progress_sitefinity_adminapp_sdk_app_api_v1_tree_custom_tree_node_component_features__WEBPACK_IMPORTED_MODULE_1__.TreeNodeComponentFeatures.RelatedData && entitySet === "newsitems") {
            const componentData = {
                type: _related_data_custom_component__WEBPACK_IMPORTED_MODULE_2__.RelatedDataCustomComponent
            };
            return componentData;
        }
        return null;
    }
}
const CUSTOM_TREE_COMPONENT_PROVIDER = {
    useClass: RelatedDataTreeNodeComponentProvider,
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1_tree__WEBPACK_IMPORTED_MODULE_0__.CUSTOM_TREE_COMPONENT_TOKEN
};


/***/ }),

/***/ "ext_mod_id_1728986549046_35":
/*!********************************************************************!*\
  !*** ./samples/tree/related-data/related-data-custom.component.ts ***!
  \********************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "RelatedDataCustomComponent": () => (/* binding */ RelatedDataCustomComponent)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_samples_tree_related_data_related_data_custom_component_ts_css_ngResource_C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_node_modules_ngtools_webpack_src_loaders_inline_resource_js_data_LmJ1bGwgeyBmb250LXdlaWdodDogYm9sZGVyOyB9_C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_samples_tree_related_data_related_data_custom_component_ts__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./samples/tree/related-data/related-data-custom.component.ts.css?ngResource!=!./node_modules/@ngtools/webpack/src/loaders/inline-resource.js?data=LmJ1bGwgeyBmb250LXdlaWdodDogYm9sZGVyOyB9!./samples/tree/related-data/related-data-custom.component.ts */ "ext_mod_id_1728986549046_80");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_tree__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1/tree */ "ext_mod_id_1728986549046_62");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1_tree__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1_tree__WEBPACK_IMPORTED_MODULE_3__);




let RelatedDataCustomComponent = class RelatedDataCustomComponent extends _progress_sitefinity_adminapp_sdk_app_api_v1_tree__WEBPACK_IMPORTED_MODULE_3__.CustomTreeNodeComponentBase {
};
RelatedDataCustomComponent.propDecorators = {
    item: [{ type: _angular_core__WEBPACK_IMPORTED_MODULE_2__.Input }]
};
RelatedDataCustomComponent = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_2__.Component)({
        template: `
    <div>
        <span [textContent]="item.data.Title"></span>
        <span class="bull">&nbsp;&bull;&nbsp;</span>
        <span data-sftest="custom-created-by" [textContent]="item.data.CreatedBy"></span>
    </div>
    <div class="sf-tree__description sf-breadcrumb -sf-overflow-ellipsis">
        <span data-sftest="custom-created-on" [textContent]="item.data.DateCreated | date:'medium'"></span>
    </div>
    `,
        styles: [C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_samples_tree_related_data_related_data_custom_component_ts_css_ngResource_C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_node_modules_ngtools_webpack_src_loaders_inline_resource_js_data_LmJ1bGwgeyBmb250LXdlaWdodDogYm9sZGVyOyB9_C_Users_paul_source_sitefinityAdminEXT_sitefinity_admin_app_extensions_samples_tree_related_data_related_data_custom_component_ts__WEBPACK_IMPORTED_MODULE_1__]
    })
], RelatedDataCustomComponent);



/***/ }),

/***/ "ext_mod_id_1728986549046_24":
/*!***********************************************************************************!*\
  !*** ./samples/widget-editor/custom-editor/custom-widget-editor-view-provider.ts ***!
  \***********************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CUSTOM_WIDGET_EDITOR_VIEW_TOKEN": () => (/* binding */ CUSTOM_WIDGET_EDITOR_VIEW_TOKEN),
/* harmony export */   "CustomWidgetEditorViewProvider": () => (/* binding */ CustomWidgetEditorViewProvider)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _custom_widget_editor_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./custom-widget-editor.component */ "ext_mod_id_1728986549046_25");




/**
 * The WidgetEditorViewProvider class provides the pluggability point to override the views for the auto generated designers.
 */
let CustomWidgetEditorViewProvider = class CustomWidgetEditorViewProvider {
    overrideView(context) {
        if (context.widgetName === "AllProperties") {
            return {
                componentData: { type: _custom_widget_editor_component__WEBPACK_IMPORTED_MODULE_3__.CustomWidgetEditorComponent }
            };
        }
    }
};
CustomWidgetEditorViewProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], CustomWidgetEditorViewProvider);

/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const CUSTOM_WIDGET_EDITOR_VIEW_TOKEN = {
    useClass: CustomWidgetEditorViewProvider,
    multi: true,
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.WIDGET_VIEW_TOKEN
};


/***/ }),

/***/ "ext_mod_id_1728986549046_25":
/*!*******************************************************************************!*\
  !*** ./samples/widget-editor/custom-editor/custom-widget-editor.component.ts ***!
  \*******************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CustomWidgetEditorComponent": () => (/* binding */ CustomWidgetEditorComponent)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _custom_widget_editor_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./custom-widget-editor.component.html?ngResource */ "ext_mod_id_1728986549046_59");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! rxjs */ "ext_mod_id_1728986549046_52");
/* harmony import */ var rxjs__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(rxjs__WEBPACK_IMPORTED_MODULE_3__);





let CustomWidgetEditorComponent = class CustomWidgetEditorComponent {
    /**
     *
     */
    constructor(detector) {
        this.detector = detector;
    }
    initialize(widgetMetadata) {
        this.heading = `${widgetMetadata.caption}`;
        this.setValues(widgetMetadata.propertyValues);
        return new rxjs__WEBPACK_IMPORTED_MODULE_3__.Observable((subscriber) => {
            subscriber.next();
        });
    }
    setValues(propValues) {
        this.propertiesValue = JSON.stringify(propValues);
    }
    validate() {
        return (0,rxjs__WEBPACK_IMPORTED_MODULE_3__.of)({
            isValid: true
        });
    }
    // eslint-disable-next-line  @typescript-eslint/no-unused-vars
    actionExecuting(context) {
        return (0,rxjs__WEBPACK_IMPORTED_MODULE_3__.of)(null);
    }
    getModifiedProperties() {
        const parsedObject = JSON.parse(this.propertiesValue);
        return Object.keys(parsedObject).map((key) => {
            return {
                Name: key,
                Value: parsedObject[key]
            };
        });
    }
    get propertiesValue() {
        return JSON.stringify(this._value, null, 2);
    }
    set propertiesValue(v) {
        try {
            this._value = JSON.parse(v);
            this.detector.detectChanges();
        }
        catch (e) {
            console.log("error occured while you were typing the JSON");
        }
    }
};
CustomWidgetEditorComponent.ctorParameters = () => [
    { type: _angular_core__WEBPACK_IMPORTED_MODULE_2__.ChangeDetectorRef }
];
CustomWidgetEditorComponent = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_2__.Component)({
        selector: "sf-content-editor",
        template: _custom_widget_editor_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__,
        encapsulation: _angular_core__WEBPACK_IMPORTED_MODULE_2__.ViewEncapsulation.None
    }),
    (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__metadata)("design:paramtypes", [_angular_core__WEBPACK_IMPORTED_MODULE_2__.ChangeDetectorRef])
], CustomWidgetEditorComponent);



/***/ }),

/***/ "ext_mod_id_1728986549046_22":
/*!****************************************************************************!*\
  !*** ./samples/widget-editor/custom-field/custom-field-write.component.ts ***!
  \****************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "CustomInputWriteComponent": () => (/* binding */ CustomInputWriteComponent)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _custom_field_write_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./custom-field-write.component.html?ngResource */ "ext_mod_id_1728986549046_58");
/* harmony import */ var _custom_field_write_component_css_ngResource__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./custom-field-write.component.css?ngResource */ "ext_mod_id_1728986549046_79");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__);





/**
 * The component used to display the field in write mode.
 * One can use inline template & styles OR templateUrl & styleUrls, like here OR mixture of that. See -readonly.component.ts version for the read mode type.
 */
let CustomInputWriteComponent = class CustomInputWriteComponent extends _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__.FieldBase {
};
CustomInputWriteComponent = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_3__.Component)({
        template: _custom_field_write_component_html_ngResource__WEBPACK_IMPORTED_MODULE_1__,
        styles: [_custom_field_write_component_css_ngResource__WEBPACK_IMPORTED_MODULE_2__]
    })
], CustomInputWriteComponent);



/***/ }),

/***/ "ext_mod_id_1728986549046_23":
/*!************************************************************************************!*\
  !*** ./samples/widget-editor/custom-field/widget-editor-custom-fields-provider.ts ***!
  \************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "WIDGET_EDITOR_CUSTOM_FIELDS_PROVIDER": () => (/* binding */ WIDGET_EDITOR_CUSTOM_FIELDS_PROVIDER),
/* harmony export */   "WidgetEditorCustomFieldsProvider": () => (/* binding */ WidgetEditorCustomFieldsProvider)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _custom_field_write_component__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./custom-field-write.component */ "ext_mod_id_1728986549046_22");





/**
 * The fields provider provides the overridden fields back to the AdminApp.
 */
let WidgetEditorCustomFieldsProvider = class WidgetEditorCustomFieldsProvider {
    /**
     * This method gets called before each field is instantiated, allowing custom fields to be plugged in for any type.
     * @param fieldRegistryKey The metadata needed to determine which field to display.
     */
    overrideField(fieldRegistryKey) {
        // the fieldRegistryKey contains the typeName of the widget prefixed with "widget-"
        if (fieldRegistryKey.fieldType === _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.FieldTypes.shortText && fieldRegistryKey.typeName && fieldRegistryKey.typeName.startsWith("widget-AllProperties"))
            return {
                writeComponent: _custom_field_write_component__WEBPACK_IMPORTED_MODULE_3__.CustomInputWriteComponent,
                settingsType: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.SettingsBase
            };
    }
};
WidgetEditorCustomFieldsProvider = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.Injectable)()
], WidgetEditorCustomFieldsProvider);

/**
 * Export a 'multi' class provider so that multiple instances of the same provider can coexist.
 * This allows for more than one provider to be registered within one or more bundles.
 */
const WIDGET_EDITOR_CUSTOM_FIELDS_PROVIDER = {
    provide: _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_2__.FIELDS_PROVIDER_TOKEN,
    useClass: WidgetEditorCustomFieldsProvider,
    multi: true
};


/***/ }),

/***/ "ext_mod_id_1728986549046_8":
/*!****************************************!*\
  !*** ./samples/widget-editor/index.ts ***!
  \****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "WidgetEditorExtenderModule": () => (/* binding */ WidgetEditorExtenderModule)
/* harmony export */ });
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! tslib */ "ext_mod_id_1728986549046_44");
/* harmony import */ var tslib__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(tslib__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! @angular/core */ "ext_mod_id_1728986549046_45");
/* harmony import */ var _angular_core__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_angular_core__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _custom_field_custom_field_write_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./custom-field/custom-field-write.component */ "ext_mod_id_1728986549046_22");
/* harmony import */ var _custom_field_widget_editor_custom_fields_provider__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./custom-field/widget-editor-custom-fields-provider */ "ext_mod_id_1728986549046_23");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! @progress/sitefinity-adminapp-sdk/app/api/v1 */ "ext_mod_id_1728986549046_48");
/* harmony import */ var _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _custom_editor_custom_widget_editor_view_provider__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./custom-editor/custom-widget-editor-view-provider */ "ext_mod_id_1728986549046_24");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! @angular/forms */ "ext_mod_id_1728986549046_46");
/* harmony import */ var _angular_forms__WEBPACK_IMPORTED_MODULE_6___default = /*#__PURE__*/__webpack_require__.n(_angular_forms__WEBPACK_IMPORTED_MODULE_6__);
/* harmony import */ var _custom_editor_custom_widget_editor_component__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./custom-editor/custom-widget-editor.component */ "ext_mod_id_1728986549046_25");








/**
 * The widget editor extender module.
 */
let WidgetEditorExtenderModule = class WidgetEditorExtenderModule {
};
WidgetEditorExtenderModule = (0,tslib__WEBPACK_IMPORTED_MODULE_0__.__decorate)([
    (0,_angular_core__WEBPACK_IMPORTED_MODULE_1__.NgModule)({
        providers: [
            _custom_field_widget_editor_custom_fields_provider__WEBPACK_IMPORTED_MODULE_3__.WIDGET_EDITOR_CUSTOM_FIELDS_PROVIDER,
            _custom_editor_custom_widget_editor_view_provider__WEBPACK_IMPORTED_MODULE_5__.CUSTOM_WIDGET_EDITOR_VIEW_TOKEN
        ],
        declarations: [
            _custom_field_custom_field_write_component__WEBPACK_IMPORTED_MODULE_2__.CustomInputWriteComponent,
            _custom_editor_custom_widget_editor_component__WEBPACK_IMPORTED_MODULE_7__.CustomWidgetEditorComponent
        ],
        imports: [
            _angular_forms__WEBPACK_IMPORTED_MODULE_6__.FormsModule, _progress_sitefinity_adminapp_sdk_app_api_v1__WEBPACK_IMPORTED_MODULE_4__.FrameworkModule
        ]
    })
], WidgetEditorExtenderModule);



/***/ }),

/***/ "ext_mod_id_1728986549046_93":
/*!*****************************************************!*\
  !*** ./node_modules/css-loader/dist/runtime/api.js ***!
  \*****************************************************/
/***/ ((module) => {

"use strict";

/*
  MIT License http://www.opensource.org/licenses/mit-license.php
  Author Tobias Koppers @sokra
*/
// css base code, injected by the css-loader
// eslint-disable-next-line func-names

module.exports = function (cssWithMappingToString) {
  var list = []; // return the list of modules as css string

  list.toString = function toString() {
    return this.map(function (item) {
      var content = cssWithMappingToString(item);

      if (item[2]) {
        return "@media ".concat(item[2], " {").concat(content, "}");
      }

      return content;
    }).join("");
  }; // import a list of modules into the list
  // eslint-disable-next-line func-names


  list.i = function (modules, mediaQuery, dedupe) {
    if (typeof modules === "string") {
      // eslint-disable-next-line no-param-reassign
      modules = [[null, modules, ""]];
    }

    var alreadyImportedModules = {};

    if (dedupe) {
      for (var i = 0; i < this.length; i++) {
        // eslint-disable-next-line prefer-destructuring
        var id = this[i][0];

        if (id != null) {
          alreadyImportedModules[id] = true;
        }
      }
    }

    for (var _i = 0; _i < modules.length; _i++) {
      var item = [].concat(modules[_i]);

      if (dedupe && alreadyImportedModules[item[0]]) {
        // eslint-disable-next-line no-continue
        continue;
      }

      if (mediaQuery) {
        if (!item[2]) {
          item[2] = mediaQuery;
        } else {
          item[2] = "".concat(mediaQuery, " and ").concat(item[2]);
        }
      }

      list.push(item);
    }
  };

  return list;
};

/***/ }),

/***/ "ext_mod_id_1728986549046_92":
/*!****************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/insert-symbol/insert-symbol.provider.css ***!
  \****************************************************************************************************************/
/***/ ((module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1728986549046_93");
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__);
// Imports

var ___CSS_LOADER_EXPORT___ = _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default()(function(i){return i[1]});
// Module
___CSS_LOADER_EXPORT___.push([module.id, ".k-icon.k-i-insertsymbol {\r\n    font-family: WebComponentsIcons;\r\n    font-size: 1.4em;\r\n}\r\n\r\n.k-i-insertsymbol::before {\r\n    font-family: WebComponentsIcons;\r\n    content: \"\\03a9\";\r\n}\r\n\r\n.k-i-insertsymbol::after {\r\n    font-family: WebComponentsIcons;\r\n    content: \"\\e006\";\r\n}\r\n\r\n.k-icon.k-i-insert-symbol::before {\r\n    padding-right: 0;\r\n}\r\n\r\n.k-state-selected .k-icon::after {\r\n    background-color: #e4e4e4;\r\n    border-radius: 0;\r\n}\r\n\r\n.symbol-cell {\r\n    font-size: 15px;\r\n    text-align: center;\r\n    display: inline-block;\r\n    cursor: pointer;\r\n    font-size: 1.1em;\r\n    color: #333333;\r\n    padding: 0px 5px 0px 5px;\r\n}\r\n\r\n.symbol-cell:hover {\r\n    color: #999999;\r\n}\r\n\r\n.k-ct-popup.symbol-popup {\r\n    display: block;\r\n    width: 350px !important;\r\n    padding: 5px 10px 10px 10px !important;\r\n}\r\n\r\n.symbol-title {\r\n    font-size: 10px;\r\n    color: #999999;\r\n    margin: 10px 5px;\r\n}\r\n", ""]);
// Exports
/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (___CSS_LOADER_EXPORT___);


/***/ }),

/***/ "ext_mod_id_1728986549046_91":
/*!*************************************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/sitefinity-images/sitefinity-images-toolbar-item-provider.css ***!
  \*************************************************************************************************************************************/
/***/ ((module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1728986549046_93");
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__);
// Imports

var ___CSS_LOADER_EXPORT___ = _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default()(function(i){return i[1]});
// Module
___CSS_LOADER_EXPORT___.push([module.id, ".k-editor-toolbar .k-i-Sitefinity-images::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e654\";\r\n}\r\n", ""]);
// Exports
/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (___CSS_LOADER_EXPORT___);


/***/ }),

/***/ "ext_mod_id_1728986549046_89":
/*!*************************************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/sitefinity-videos/sitefinity-videos-toolbar-item-provider.css ***!
  \*************************************************************************************************************************************/
/***/ ((module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1728986549046_93");
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__);
// Imports

var ___CSS_LOADER_EXPORT___ = _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default()(function(i){return i[1]});
// Module
___CSS_LOADER_EXPORT___.push([module.id, ".k-editor-toolbar .k-i-Sitefinity-videos::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e659\";\r\n}\r\n", ""]);
// Exports
/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (___CSS_LOADER_EXPORT___);


/***/ }),

/***/ "ext_mod_id_1728986549046_90":
/*!*******************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/spell-check/editor-spell-check-provider.css ***!
  \*******************************************************************************************************************/
/***/ ((module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1728986549046_93");
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__);
// Imports

var ___CSS_LOADER_EXPORT___ = _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default()(function(i){return i[1]});
// Module
___CSS_LOADER_EXPORT___.push([module.id, ".k-editor-toolbar .k-i-Spell-correction::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e13c\";\r\n}\r\n\r\n.k-editor-toolbar .k-i-Spell-check::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e68d\";\r\n}\r\n\r\nspan[suggestion] {\r\n    background-color: yellow;\r\n}\r\n", ""]);
// Exports
/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (___CSS_LOADER_EXPORT___);


/***/ }),

/***/ "ext_mod_id_1728986549046_88":
/*!********************************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/switch-text-direction/switch-text-direction.provider.css ***!
  \********************************************************************************************************************************/
/***/ ((module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1728986549046_93");
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__);
// Imports

var ___CSS_LOADER_EXPORT___ = _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default()(function(i){return i[1]});
// Module
___CSS_LOADER_EXPORT___.push([module.id, ".k-icon.k-i-Left-to-right,\r\n.k-icon.k-i-Right-to-left {\r\n    font-family: FontAwesome;\r\n    font-size: 16px !important;\r\n    width: auto !important;\r\n}\r\n\r\n.k-i-Right-to-left::after {\r\n    content: \"\\f0d9\";\r\n}\r\n\r\n.k-i-Right-to-left::before {\r\n    content: \"\\f1dd\";\r\n}\r\n\r\n.k-i-Left-to-right::after {\r\n    content: \"\\f1dd\";\r\n}\r\n\r\n.k-i-Left-to-right::before {\r\n    content: \"\\f0da\";\r\n    margin-left: 15px;\r\n}\r\n\r\n.k-icon.k-i-Left-to-right::before,\r\n.k-icon.k-i-Right-to-left::before {\r\n    padding-right: 0;\r\n    width: auto !important;\r\n}\r\n\r\n.k-icon.k-i-Left-to-right::after,\r\n.k-icon.k-i-Right-to-left::after {\r\n    padding: 5px 5px 5px 0;\r\n    height: 25px !important;\r\n}\r\n\r\n.k-icon.k-i-Right-to-left::before {\r\n    margin-right: 0 !important;\r\n}\r\n\r\n.k-icon.k-i-Right-to-left::after {\r\n    margin-right: 15px;\r\n}\r\n\r\n.k-state-selected .k-icon::after {\r\n    background-color: #e4e4e4;\r\n    border-radius: 0;\r\n}\r\n", ""]);
// Exports
/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (___CSS_LOADER_EXPORT___);


/***/ }),

/***/ "ext_mod_id_1728986549046_87":
/*!*************************************************************************************************************!*\
  !*** ./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/word-count/editor-config-provider.css ***!
  \*************************************************************************************************************/
/***/ ((module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../../../node_modules/css-loader/dist/runtime/api.js */ "ext_mod_id_1728986549046_93");
/* harmony import */ var _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0__);
// Imports

var ___CSS_LOADER_EXPORT___ = _node_modules_css_loader_dist_runtime_api_js__WEBPACK_IMPORTED_MODULE_0___default()(function(i){return i[1]});
// Module
___CSS_LOADER_EXPORT___.push([module.id, ".k-editor-toolbar .k-i-Words-count::before {\r\n    /* Kendo UI Icons: https://docs.telerik.com/kendo-ui/styles-and-layout/icons-web */\r\n    content: \"\\e696\";\r\n}\r\n", ""]);
// Exports
/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (___CSS_LOADER_EXPORT___);


/***/ }),

/***/ "ext_mod_id_1728986549046_76":
/*!********************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/insert-symbol/insert-symbol.provider.css ***!
  \********************************************************************************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1728986549046_81");
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleDomAPI.js */ "ext_mod_id_1728986549046_82");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertBySelector.js */ "ext_mod_id_1728986549046_83");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/setAttributesWithoutAttributes.js */ "ext_mod_id_1728986549046_84");
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertStyleElement.js */ "ext_mod_id_1728986549046_85");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleTagTransform.js */ "ext_mod_id_1728986549046_86");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _node_modules_css_loader_dist_cjs_js_insert_symbol_provider_css__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! !!../../../node_modules/css-loader/dist/cjs.js!./insert-symbol.provider.css */ "ext_mod_id_1728986549046_92");

      
      
      
      
      
      
      
      
      

var options = {};

options.styleTagTransform = (_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default());
options.setAttributes = (_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default());

      options.insert = _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default().bind(null, "head");
    
options.domAPI = (_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default());
options.insertStyleElement = (_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default());

var update = _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default()(_node_modules_css_loader_dist_cjs_js_insert_symbol_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"], options);




       /* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (_node_modules_css_loader_dist_cjs_js_insert_symbol_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"] && _node_modules_css_loader_dist_cjs_js_insert_symbol_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals ? _node_modules_css_loader_dist_cjs_js_insert_symbol_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals : undefined);


/***/ }),

/***/ "ext_mod_id_1728986549046_75":
/*!*****************************************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/sitefinity-images/sitefinity-images-toolbar-item-provider.css ***!
  \*****************************************************************************************************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1728986549046_81");
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleDomAPI.js */ "ext_mod_id_1728986549046_82");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertBySelector.js */ "ext_mod_id_1728986549046_83");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/setAttributesWithoutAttributes.js */ "ext_mod_id_1728986549046_84");
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertStyleElement.js */ "ext_mod_id_1728986549046_85");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleTagTransform.js */ "ext_mod_id_1728986549046_86");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _node_modules_css_loader_dist_cjs_js_sitefinity_images_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! !!../../../node_modules/css-loader/dist/cjs.js!./sitefinity-images-toolbar-item-provider.css */ "ext_mod_id_1728986549046_91");

      
      
      
      
      
      
      
      
      

var options = {};

options.styleTagTransform = (_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default());
options.setAttributes = (_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default());

      options.insert = _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default().bind(null, "head");
    
options.domAPI = (_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default());
options.insertStyleElement = (_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default());

var update = _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default()(_node_modules_css_loader_dist_cjs_js_sitefinity_images_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"], options);




       /* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (_node_modules_css_loader_dist_cjs_js_sitefinity_images_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"] && _node_modules_css_loader_dist_cjs_js_sitefinity_images_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals ? _node_modules_css_loader_dist_cjs_js_sitefinity_images_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals : undefined);


/***/ }),

/***/ "ext_mod_id_1728986549046_73":
/*!*****************************************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/sitefinity-videos/sitefinity-videos-toolbar-item-provider.css ***!
  \*****************************************************************************************************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1728986549046_81");
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleDomAPI.js */ "ext_mod_id_1728986549046_82");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertBySelector.js */ "ext_mod_id_1728986549046_83");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/setAttributesWithoutAttributes.js */ "ext_mod_id_1728986549046_84");
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertStyleElement.js */ "ext_mod_id_1728986549046_85");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleTagTransform.js */ "ext_mod_id_1728986549046_86");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _node_modules_css_loader_dist_cjs_js_sitefinity_videos_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! !!../../../node_modules/css-loader/dist/cjs.js!./sitefinity-videos-toolbar-item-provider.css */ "ext_mod_id_1728986549046_89");

      
      
      
      
      
      
      
      
      

var options = {};

options.styleTagTransform = (_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default());
options.setAttributes = (_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default());

      options.insert = _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default().bind(null, "head");
    
options.domAPI = (_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default());
options.insertStyleElement = (_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default());

var update = _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default()(_node_modules_css_loader_dist_cjs_js_sitefinity_videos_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"], options);




       /* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (_node_modules_css_loader_dist_cjs_js_sitefinity_videos_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"] && _node_modules_css_loader_dist_cjs_js_sitefinity_videos_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals ? _node_modules_css_loader_dist_cjs_js_sitefinity_videos_toolbar_item_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals : undefined);


/***/ }),

/***/ "ext_mod_id_1728986549046_74":
/*!***********************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/spell-check/editor-spell-check-provider.css ***!
  \***********************************************************************************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1728986549046_81");
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleDomAPI.js */ "ext_mod_id_1728986549046_82");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertBySelector.js */ "ext_mod_id_1728986549046_83");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/setAttributesWithoutAttributes.js */ "ext_mod_id_1728986549046_84");
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertStyleElement.js */ "ext_mod_id_1728986549046_85");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleTagTransform.js */ "ext_mod_id_1728986549046_86");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _node_modules_css_loader_dist_cjs_js_editor_spell_check_provider_css__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! !!../../../node_modules/css-loader/dist/cjs.js!./editor-spell-check-provider.css */ "ext_mod_id_1728986549046_90");

      
      
      
      
      
      
      
      
      

var options = {};

options.styleTagTransform = (_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default());
options.setAttributes = (_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default());

      options.insert = _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default().bind(null, "head");
    
options.domAPI = (_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default());
options.insertStyleElement = (_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default());

var update = _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default()(_node_modules_css_loader_dist_cjs_js_editor_spell_check_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"], options);




       /* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (_node_modules_css_loader_dist_cjs_js_editor_spell_check_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"] && _node_modules_css_loader_dist_cjs_js_editor_spell_check_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals ? _node_modules_css_loader_dist_cjs_js_editor_spell_check_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals : undefined);


/***/ }),

/***/ "ext_mod_id_1728986549046_72":
/*!************************************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/switch-text-direction/switch-text-direction.provider.css ***!
  \************************************************************************************************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1728986549046_81");
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleDomAPI.js */ "ext_mod_id_1728986549046_82");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertBySelector.js */ "ext_mod_id_1728986549046_83");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/setAttributesWithoutAttributes.js */ "ext_mod_id_1728986549046_84");
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertStyleElement.js */ "ext_mod_id_1728986549046_85");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleTagTransform.js */ "ext_mod_id_1728986549046_86");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _node_modules_css_loader_dist_cjs_js_switch_text_direction_provider_css__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! !!../../../node_modules/css-loader/dist/cjs.js!./switch-text-direction.provider.css */ "ext_mod_id_1728986549046_88");

      
      
      
      
      
      
      
      
      

var options = {};

options.styleTagTransform = (_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default());
options.setAttributes = (_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default());

      options.insert = _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default().bind(null, "head");
    
options.domAPI = (_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default());
options.insertStyleElement = (_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default());

var update = _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default()(_node_modules_css_loader_dist_cjs_js_switch_text_direction_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"], options);




       /* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (_node_modules_css_loader_dist_cjs_js_switch_text_direction_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"] && _node_modules_css_loader_dist_cjs_js_switch_text_direction_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals ? _node_modules_css_loader_dist_cjs_js_switch_text_direction_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals : undefined);


/***/ }),

/***/ "ext_mod_id_1728986549046_71":
/*!*****************************************************************************************************************************************************!*\
  !*** ./node_modules/style-loader/dist/cjs.js!./node_modules/css-loader/dist/cjs.js!./samples/editor-extender/word-count/editor-config-provider.css ***!
  \*****************************************************************************************************************************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js */ "ext_mod_id_1728986549046_81");
/* harmony import */ var _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleDomAPI.js */ "ext_mod_id_1728986549046_82");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertBySelector.js */ "ext_mod_id_1728986549046_83");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/setAttributesWithoutAttributes.js */ "ext_mod_id_1728986549046_84");
/* harmony import */ var _node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/insertStyleElement.js */ "ext_mod_id_1728986549046_85");
/* harmony import */ var _node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4__);
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! !../../../node_modules/style-loader/dist/runtime/styleTagTransform.js */ "ext_mod_id_1728986549046_86");
/* harmony import */ var _node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default = /*#__PURE__*/__webpack_require__.n(_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5__);
/* harmony import */ var _node_modules_css_loader_dist_cjs_js_editor_config_provider_css__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! !!../../../node_modules/css-loader/dist/cjs.js!./editor-config-provider.css */ "ext_mod_id_1728986549046_87");

      
      
      
      
      
      
      
      
      

var options = {};

options.styleTagTransform = (_node_modules_style_loader_dist_runtime_styleTagTransform_js__WEBPACK_IMPORTED_MODULE_5___default());
options.setAttributes = (_node_modules_style_loader_dist_runtime_setAttributesWithoutAttributes_js__WEBPACK_IMPORTED_MODULE_3___default());

      options.insert = _node_modules_style_loader_dist_runtime_insertBySelector_js__WEBPACK_IMPORTED_MODULE_2___default().bind(null, "head");
    
options.domAPI = (_node_modules_style_loader_dist_runtime_styleDomAPI_js__WEBPACK_IMPORTED_MODULE_1___default());
options.insertStyleElement = (_node_modules_style_loader_dist_runtime_insertStyleElement_js__WEBPACK_IMPORTED_MODULE_4___default());

var update = _node_modules_style_loader_dist_runtime_injectStylesIntoStyleTag_js__WEBPACK_IMPORTED_MODULE_0___default()(_node_modules_css_loader_dist_cjs_js_editor_config_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"], options);




       /* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (_node_modules_css_loader_dist_cjs_js_editor_config_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"] && _node_modules_css_loader_dist_cjs_js_editor_config_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals ? _node_modules_css_loader_dist_cjs_js_editor_config_provider_css__WEBPACK_IMPORTED_MODULE_6__["default"].locals : undefined);


/***/ }),

/***/ "ext_mod_id_1728986549046_81":
/*!****************************************************************************!*\
  !*** ./node_modules/style-loader/dist/runtime/injectStylesIntoStyleTag.js ***!
  \****************************************************************************/
/***/ ((module) => {

"use strict";


var stylesInDOM = [];

function getIndexByIdentifier(identifier) {
  var result = -1;

  for (var i = 0; i < stylesInDOM.length; i++) {
    if (stylesInDOM[i].identifier === identifier) {
      result = i;
      break;
    }
  }

  return result;
}

function modulesToDom(list, options) {
  var idCountMap = {};
  var identifiers = [];

  for (var i = 0; i < list.length; i++) {
    var item = list[i];
    var id = options.base ? item[0] + options.base : item[0];
    var count = idCountMap[id] || 0;
    var identifier = "".concat(id, " ").concat(count);
    idCountMap[id] = count + 1;
    var indexByIdentifier = getIndexByIdentifier(identifier);
    var obj = {
      css: item[1],
      media: item[2],
      sourceMap: item[3],
      supports: item[4],
      layer: item[5]
    };

    if (indexByIdentifier !== -1) {
      stylesInDOM[indexByIdentifier].references++;
      stylesInDOM[indexByIdentifier].updater(obj);
    } else {
      var updater = addElementStyle(obj, options);
      options.byIndex = i;
      stylesInDOM.splice(i, 0, {
        identifier: identifier,
        updater: updater,
        references: 1
      });
    }

    identifiers.push(identifier);
  }

  return identifiers;
}

function addElementStyle(obj, options) {
  var api = options.domAPI(options);
  api.update(obj);

  var updater = function updater(newObj) {
    if (newObj) {
      if (newObj.css === obj.css && newObj.media === obj.media && newObj.sourceMap === obj.sourceMap && newObj.supports === obj.supports && newObj.layer === obj.layer) {
        return;
      }

      api.update(obj = newObj);
    } else {
      api.remove();
    }
  };

  return updater;
}

module.exports = function (list, options) {
  options = options || {};
  list = list || [];
  var lastIdentifiers = modulesToDom(list, options);
  return function update(newList) {
    newList = newList || [];

    for (var i = 0; i < lastIdentifiers.length; i++) {
      var identifier = lastIdentifiers[i];
      var index = getIndexByIdentifier(identifier);
      stylesInDOM[index].references--;
    }

    var newLastIdentifiers = modulesToDom(newList, options);

    for (var _i = 0; _i < lastIdentifiers.length; _i++) {
      var _identifier = lastIdentifiers[_i];

      var _index = getIndexByIdentifier(_identifier);

      if (stylesInDOM[_index].references === 0) {
        stylesInDOM[_index].updater();

        stylesInDOM.splice(_index, 1);
      }
    }

    lastIdentifiers = newLastIdentifiers;
  };
};

/***/ }),

/***/ "ext_mod_id_1728986549046_83":
/*!********************************************************************!*\
  !*** ./node_modules/style-loader/dist/runtime/insertBySelector.js ***!
  \********************************************************************/
/***/ ((module) => {

"use strict";


var memo = {};
/* istanbul ignore next  */

function getTarget(target) {
  if (typeof memo[target] === "undefined") {
    var styleTarget = document.querySelector(target); // Special case to return head of iframe instead of iframe itself

    if (window.HTMLIFrameElement && styleTarget instanceof window.HTMLIFrameElement) {
      try {
        // This will throw an exception if access to iframe is blocked
        // due to cross-origin restrictions
        styleTarget = styleTarget.contentDocument.head;
      } catch (e) {
        // istanbul ignore next
        styleTarget = null;
      }
    }

    memo[target] = styleTarget;
  }

  return memo[target];
}
/* istanbul ignore next  */


function insertBySelector(insert, style) {
  var target = getTarget(insert);

  if (!target) {
    throw new Error("Couldn't find a style target. This probably means that the value for the 'insert' parameter is invalid.");
  }

  target.appendChild(style);
}

module.exports = insertBySelector;

/***/ }),

/***/ "ext_mod_id_1728986549046_85":
/*!**********************************************************************!*\
  !*** ./node_modules/style-loader/dist/runtime/insertStyleElement.js ***!
  \**********************************************************************/
/***/ ((module) => {

"use strict";


/* istanbul ignore next  */
function insertStyleElement(options) {
  var element = document.createElement("style");
  options.setAttributes(element, options.attributes);
  options.insert(element, options.options);
  return element;
}

module.exports = insertStyleElement;

/***/ }),

/***/ "ext_mod_id_1728986549046_84":
/*!**********************************************************************************!*\
  !*** ./node_modules/style-loader/dist/runtime/setAttributesWithoutAttributes.js ***!
  \**********************************************************************************/
/***/ ((module, __unused_webpack_exports, __webpack_require__) => {

"use strict";


/* istanbul ignore next  */
function setAttributesWithoutAttributes(styleElement) {
  var nonce =  true ? __webpack_require__.nc : 0;

  if (nonce) {
    styleElement.setAttribute("nonce", nonce);
  }
}

module.exports = setAttributesWithoutAttributes;

/***/ }),

/***/ "ext_mod_id_1728986549046_82":
/*!***************************************************************!*\
  !*** ./node_modules/style-loader/dist/runtime/styleDomAPI.js ***!
  \***************************************************************/
/***/ ((module) => {

"use strict";


/* istanbul ignore next  */
function apply(styleElement, options, obj) {
  var css = "";

  if (obj.supports) {
    css += "@supports (".concat(obj.supports, ") {");
  }

  if (obj.media) {
    css += "@media ".concat(obj.media, " {");
  }

  var needLayer = typeof obj.layer !== "undefined";

  if (needLayer) {
    css += "@layer".concat(obj.layer.length > 0 ? " ".concat(obj.layer) : "", " {");
  }

  css += obj.css;

  if (needLayer) {
    css += "}";
  }

  if (obj.media) {
    css += "}";
  }

  if (obj.supports) {
    css += "}";
  }

  var sourceMap = obj.sourceMap;

  if (sourceMap && typeof btoa !== "undefined") {
    css += "\n/*# sourceMappingURL=data:application/json;base64,".concat(btoa(unescape(encodeURIComponent(JSON.stringify(sourceMap)))), " */");
  } // For old IE

  /* istanbul ignore if  */


  options.styleTagTransform(css, styleElement, options.options);
}

function removeStyleElement(styleElement) {
  // istanbul ignore if
  if (styleElement.parentNode === null) {
    return false;
  }

  styleElement.parentNode.removeChild(styleElement);
}
/* istanbul ignore next  */


function domAPI(options) {
  var styleElement = options.insertStyleElement(options);
  return {
    update: function update(obj) {
      apply(styleElement, options, obj);
    },
    remove: function remove() {
      removeStyleElement(styleElement);
    }
  };
}

module.exports = domAPI;

/***/ }),

/***/ "ext_mod_id_1728986549046_86":
/*!*********************************************************************!*\
  !*** ./node_modules/style-loader/dist/runtime/styleTagTransform.js ***!
  \*********************************************************************/
/***/ ((module) => {

"use strict";


/* istanbul ignore next  */
function styleTagTransform(css, styleElement) {
  if (styleElement.styleSheet) {
    styleElement.styleSheet.cssText = css;
  } else {
    while (styleElement.firstChild) {
      styleElement.removeChild(styleElement.firstChild);
    }

    styleElement.appendChild(document.createTextNode(css));
  }
}

module.exports = styleTagTransform;

/***/ }),

/***/ "ext_mod_id_1728986549046_77":
/*!***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************!*\
  !*** ./samples/custom-fields/custom-field-readonly.component.ts.css?ngResource!=!./node_modules/@ngtools/webpack/src/loaders/inline-resource.js?data=CiAgICAgICAgLmN1c3RvbS10aXRsZS1pbnB1dCB7CiAgICAgICAgICAgIGJvcmRlcjogMDsKICAgICAgICAgICAgcGFkZGluZzogMDsKICAgICAgICAgICAgZm9udC13ZWlnaHQ6IDcwMDsKICAgICAgICAgICAgZm9udC1zaXplOiAzZW07CiAgICAgICAgICAgIHdpZHRoOiAxMDAlOwogICAgICAgICAgICBjb2xvcjogIzY2NjsKICAgICAgICB9CiAgICAgICAg!./samples/custom-fields/custom-field-readonly.component.ts ***!
  \***************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = "\n        .custom-title-input {\n            border: 0;\n            padding: 0;\n            font-weight: 700;\n            font-size: 3em;\n            width: 100%;\n            color: #666;\n        }\n        ";

/***/ }),

/***/ "ext_mod_id_1728986549046_80":
/*!***************************************************************************************************************************************************************************************************************************************************************!*\
  !*** ./samples/tree/related-data/related-data-custom.component.ts.css?ngResource!=!./node_modules/@ngtools/webpack/src/loaders/inline-resource.js?data=LmJ1bGwgeyBmb250LXdlaWdodDogYm9sZGVyOyB9!./samples/tree/related-data/related-data-custom.component.ts ***!
  \***************************************************************************************************************************************************************************************************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = ".bull { font-weight: bolder; }";

/***/ }),

/***/ "ext_mod_id_1728986549046_78":
/*!***************************************************************************!*\
  !*** ./samples/custom-fields/custom-field-write.component.css?ngResource ***!
  \***************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = ".custom-title-input {\r\n    border: 0;\r\n    border-bottom: 2px dashed #38ab63;\r\n    padding: .2em;\r\n    font-weight: 700;\r\n    font-size: 3em;\r\n    width: 100%;\r\n    color: #38ab63;\r\n}\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_79":
/*!****************************************************************************************!*\
  !*** ./samples/widget-editor/custom-field/custom-field-write.component.css?ngResource ***!
  \****************************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = ".custom-title-input {\r\n    border: 0;\r\n    border-bottom: 2px dashed #38ab63;\r\n    padding: .2em;\r\n    font-weight: 700;\r\n    font-size: 3em;\r\n    width: 100%;\r\n    color: #38ab63;\r\n}\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_70":
/*!***************************************************************************!*\
  !*** ./samples/commands-extender/print-preview.component.html?ngResource ***!
  \***************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = "<div style=\"position: fixed;top: 50%;left: 50%;\">\r\n    <h1 *ngIf=\"dataItem\" [textContent]=\"dataItem.Title\"></h1>\r\n    <h1 *ngIf=\"!dataItem\">Loading..</h1>\r\n</div>\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_56":
/*!************************************************************************************************!*\
  !*** ./samples/custom-fields/array-of-guids/array-of-guids-readonly.component.html?ngResource ***!
  \************************************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = "<input class=\"custom-title-input\" [value]=\"value\" readonly />\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_57":
/*!*********************************************************************************************!*\
  !*** ./samples/custom-fields/array-of-guids/array-of-guids-write.component.html?ngResource ***!
  \*********************************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = "<sf-input\r\n    [name]=\"settings.key\"\r\n    [look]=\"settings.look\"\r\n    [placeholder]=\"settings.placeholder\"\r\n    ngDefaultControl\r\n    [(ngModel)]=\"value\">\r\n</sf-input>\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_55":
/*!*******************************************************************************!*\
  !*** ./samples/custom-fields/custom-field-readonly.component.html?ngResource ***!
  \*******************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = " <input class=\"custom-title-input\" [value]=\"value\" readonly />\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_54":
/*!****************************************************************************!*\
  !*** ./samples/custom-fields/custom-field-write.component.html?ngResource ***!
  \****************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = "<sf-input\r\n    [name]=\"settings.key\"\r\n    [look]=\"settings.look\"\r\n    [placeholder]=\"settings.placeholder\"\r\n    [recommendedCharacters]=\"settings.recommendedCharacters\"\r\n    #inputField\r\n    ngDefaultControl\r\n    [(ngModel)]=\"value\"\r\n    (onBlur)=\"onBlur()\"\r\n    (onFocus)=\"onFocus()\">\r\n</sf-input>\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_53":
/*!***************************************************************!*\
  !*** ./samples/grid-extender/image.component.html?ngResource ***!
  \***************************************************************/
/***/ ((module) => {

"use strict";
module.exports = "<img [style.height.px]=\"imageHeight\" [src]=\"imageSource\" />\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_59":
/*!********************************************************************************************!*\
  !*** ./samples/widget-editor/custom-editor/custom-widget-editor.component.html?ngResource ***!
  \********************************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = "<div class=\"sf-form -medium -sf-centered-box -sf-pb-zero -sf-pt-7xl\">\r\n    <h1>{{heading}}</h1>\r\n    <div class=\"-sf-mb-4xl -sf-mt-4xl -sf-txt-align-left -textarea sf-input\">\r\n        <textarea class=\"sf-input__field\" [(ngModel)]='propertiesValue' ngDefaultControl>\r\n        </textarea>\r\n    </div>\r\n</div>\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_58":
/*!*****************************************************************************************!*\
  !*** ./samples/widget-editor/custom-field/custom-field-write.component.html?ngResource ***!
  \*****************************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = "<sf-input\r\n    [name]=\"settings.key\"\r\n    [look]=\"settings.look\"\r\n    [placeholder]=\"settings.placeholder\"\r\n    [recommendedCharacters]=\"settings.recommendedCharacters\"\r\n    #inputField\r\n    ngDefaultControl\r\n    [(ngModel)]=\"value\"\r\n    (onBlur)=\"onBlur()\"\r\n    (onFocus)=\"onFocus()\">\r\n</sf-input>\r\n";

/***/ }),

/***/ "ext_mod_id_1728986549046_60":
/*!*********************************************************************************************************************************!*\
  !*** delegated ./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/theme/theme-provider.js from dll-reference adminapp ***!
  \*********************************************************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/theme/theme-provider.js')

/***/ }),

/***/ "ext_mod_id_1728986549046_61":
/*!**********************************************************************************************************************************!*\
  !*** delegated ./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/theme/theme-variables.js from dll-reference adminapp ***!
  \**********************************************************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/theme/theme-variables.js')

/***/ }),

/***/ "ext_mod_id_1728986549046_62":
/*!***********************************************************************************************************************!*\
  !*** delegated ./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/tree/index.js from dll-reference adminapp ***!
  \***********************************************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/tree/index.js')

/***/ }),

/***/ "ext_mod_id_1728986549046_63":
/*!*****************************************************************************************************************************************************!*\
  !*** delegated ./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/tree/custom-tree-node-component-features.js from dll-reference adminapp ***!
  \*****************************************************************************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/tree/custom-tree-node-component-features.js')

/***/ }),

/***/ "ext_mod_id_1728986549046_65":
/*!*********************************************************************************************!*\
  !*** delegated ./node_modules/rxjs/dist/esm/operators/index.js from dll-reference adminapp ***!
  \*********************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/rxjs/dist/esm/operators/index.js')

/***/ }),

/***/ "ext_mod_id_1728986549046_44":
/*!*******************************************************************************!*\
  !*** delegated ./node_modules/tslib/tslib.es6.js from dll-reference adminapp ***!
  \*******************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/tslib/tslib.es6.js')

/***/ }),

/***/ "ext_mod_id_1728986549046_45":
/*!********************************************************************************************!*\
  !*** delegated ./node_modules/@angular/core/fesm2015/core.mjs from dll-reference adminapp ***!
  \********************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@angular/core/fesm2015/core.mjs')

/***/ }),

/***/ "ext_mod_id_1728986549046_46":
/*!**********************************************************************************************!*\
  !*** delegated ./node_modules/@angular/forms/fesm2015/forms.mjs from dll-reference adminapp ***!
  \**********************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@angular/forms/fesm2015/forms.mjs')

/***/ }),

/***/ "ext_mod_id_1728986549046_47":
/*!************************************************************************************************!*\
  !*** delegated ./node_modules/@angular/common/fesm2015/common.mjs from dll-reference adminapp ***!
  \************************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@angular/common/fesm2015/common.mjs')

/***/ }),

/***/ "ext_mod_id_1728986549046_48":
/*!******************************************************************************************************************!*\
  !*** delegated ./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/index.js from dll-reference adminapp ***!
  \******************************************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@progress/sitefinity-adminapp-sdk/app/api/v1/index.js')

/***/ }),

/***/ "ext_mod_id_1728986549046_49":
/*!**********************************************************************************************!*\
  !*** delegated ./node_modules/@angular/common/fesm2015/http.mjs from dll-reference adminapp ***!
  \**********************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@angular/common/fesm2015/http.mjs')

/***/ }),

/***/ "ext_mod_id_1728986549046_50":
/*!************************************************************************************************!*\
  !*** delegated ./node_modules/@angular/router/fesm2015/router.mjs from dll-reference adminapp ***!
  \************************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/@angular/router/fesm2015/router.mjs')

/***/ }),

/***/ "ext_mod_id_1728986549046_51":
/*!****************************************************************************************************!*\
  !*** delegated ./node_modules/rxjs/dist/esm/internal/operators/map.js from dll-reference adminapp ***!
  \****************************************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/rxjs/dist/esm/internal/operators/map.js')

/***/ }),

/***/ "ext_mod_id_1728986549046_52":
/*!***********************************************************************************!*\
  !*** delegated ./node_modules/rxjs/dist/esm/index.js from dll-reference adminapp ***!
  \***********************************************************************************/
/***/ ((module) => {

module.exports = __iris_require__('./node_modules/rxjs/dist/esm/index.js')

/***/ }),

/***/ "ext_mod_id_1728986549046_64":
/*!***************************!*\
  !*** external "adminapp" ***!
  \***************************/
/***/ ((module) => {

"use strict";
module.exports = adminapp;

/***/ }),

/***/ "ext_mod_id_1728986549046_68":
/*!****************************************************************************!*\
  !*** ./samples/editor-extender/insert-symbol/symbol-list/symbol-list.json ***!
  \****************************************************************************/
/***/ ((module) => {

"use strict";
module.exports = JSON.parse('[{"name":"\\"","value":"\\"","escapedValue":"&amp;quot; &amp;QUOT;","tooltip":"QUOTATION MARK"},{"name":"¢","value":"¢","escapedValue":"&amp;cent;","tooltip":"CENT SIGN"},{"name":"€","value":"€","escapedValue":"&amp;euro;","tooltip":"EURO SIGN"},{"name":"£","value":"£","escapedValue":"&amp;pound;","tooltip":"POUND SIGN"},{"name":"¥","value":"¥","escapedValue":"&amp;yen;","tooltip":"YEN SIGN"},{"name":"©","value":"©","escapedValue":"&amp;copy; &amp;COPY;","tooltip":"COPYRIGHT SIGN"},{"name":"®","value":"®","escapedValue":"&amp;reg; &amp;circledR; &amp;REG;","tooltip":"REGISTERED SIGN"},{"name":"™","value":"™","escapedValue":"&amp;trade; &amp;TRADE;","tooltip":"TRADE MARK SIGN"},{"name":"‰","value":"‰","escapedValue":"&amp;permil;","tooltip":"PER MILLE SIGN"},{"name":"µ","value":"µ","escapedValue":"&amp;micro;","tooltip":"MICRO SIGN"},{"name":"·","value":"·","escapedValue":"&amp;middot; &amp;centerdot; &amp;CenterDot;","tooltip":"MIDDLE DOT"},{"name":"•","value":"•","escapedValue":"&amp;bull; &amp;bullet;","tooltip":"BULLET"},{"name":"…","value":"…","escapedValue":"&amp;hellip; &amp;mldr;","tooltip":"HORIZONTAL ELLIPSIS"},{"name":"′","value":"′","escapedValue":"&amp;prime;","tooltip":"PRIME"},{"name":"″","value":"″","escapedValue":"&amp;Prime;","tooltip":"DOUBLE PRIME"},{"name":"§","value":"§","escapedValue":"&amp;sect;","tooltip":"SECTION SIGN"},{"name":"¶","value":"¶","escapedValue":"&amp;para;","tooltip":"PILCROW SIGN"},{"name":"ß","value":"ß","escapedValue":"&amp;szlig;","tooltip":"LATIN SMALL LETTER SHARP S"},{"name":"‹","value":"‹","escapedValue":"&amp;lsaquo;","tooltip":"SINGLE LEFT-POINTING ANGLE QUOTATION MARK"},{"name":"›","value":"›","escapedValue":"&amp;rsaquo;","tooltip":"SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"},{"name":"«","value":"«","escapedValue":"&amp;laquo;","tooltip":"LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"},{"name":"»","value":"»","escapedValue":"&amp;raquo;","tooltip":"RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"},{"name":"‘","value":"‘","escapedValue":"&amp;lsquo; &amp;OpenCurlyQuote;","tooltip":"LEFT SINGLE QUOTATION MARK"},{"name":"’","value":"’","escapedValue":"&amp;rsquo; &amp;rsquor; &amp;CloseCurlyQuote;","tooltip":"RIGHT SINGLE QUOTATION MARK"},{"name":"“","value":"“","escapedValue":"&amp;ldquo; &amp;OpenCurlyDoubleQuote;","tooltip":"LEFT DOUBLE QUOTATION MARK"},{"name":"”","value":"”","escapedValue":"&amp;rdquo; &amp;rdquor; &amp;CloseCurlyDoubleQuote;","tooltip":"RIGHT DOUBLE QUOTATION MARK"},{"name":"‚","value":"‚","escapedValue":"&amp;lsquor; &amp;sbquo;","tooltip":"SINGLE LOW-9 QUOTATION MARK"},{"name":"„","value":"„","escapedValue":"&amp;ldquor; &amp;bdquo;","tooltip":"DOUBLE LOW-9 QUOTATION MARK"},{"name":"<","value":"<","escapedValue":"&amp;lt; &amp;LT;","tooltip":"LESS-THAN SIGN"},{"name":">","value":">","escapedValue":"&amp;gt; &amp;GT;","tooltip":"GREATER-THAN SIGN"},{"name":"≤","value":"≤","escapedValue":"&amp;le; &amp;leq;","tooltip":"LESS-THAN OR EQUAL TO"},{"name":"≥","value":"≥","escapedValue":"&amp;ge; &amp;GreaterEqual; &amp;geq;","tooltip":"GREATER-THAN OR EQUAL TO"},{"name":"–","value":"–","escapedValue":"&amp;ndash;","tooltip":"EN DASH"},{"name":"—","value":"—","escapedValue":"&amp;mdash;","tooltip":"EM DASH"},{"name":"¯","value":"¯","escapedValue":"&amp;macr; &amp;OverBar; &amp;strns;","tooltip":"MACRON"},{"name":"‾","value":"‾","escapedValue":"&amp;oline;","tooltip":"OVERLINE"},{"name":"¤","value":"¤","escapedValue":"&amp;curren;","tooltip":"CURRENCY SIGN"},{"name":"¦","value":"¦","escapedValue":"&amp;brvbar;","tooltip":"BROKEN BAR"},{"name":"¨","value":"¨","escapedValue":"&amp;Dot; &amp;die; &amp;DoubleDot; &amp;uml;","tooltip":"DIAERESIS"},{"name":"¡","value":"¡","escapedValue":"&amp;iexcl;","tooltip":"INVERTED EXCLAMATION MARK"},{"name":"¿","value":"¿","escapedValue":"&amp;iquest;","tooltip":"INVERTED QUESTION MARK"},{"name":"ˆ","value":"ˆ","escapedValue":"&amp;circ;","tooltip":"MODIFIER LETTER CIRCUMFLEX ACCENT"},{"name":"˜","value":"˜","escapedValue":"&amp;tilde; &amp;DiacriticalTilde;","tooltip":"SMALL TILDE"},{"name":"°","value":"°","escapedValue":"&amp;deg;","tooltip":"DEGREE SIGN"},{"name":"−","value":"−","escapedValue":"&amp;minus;","tooltip":"MINUS SIGN"},{"name":"±","value":"±","escapedValue":"&amp;plusmn; &amp;pm; &amp;PlusMinus;","tooltip":"PLUS-MINUS SIGN"},{"name":"÷","value":"÷","escapedValue":"&amp;divide; &amp;div;","tooltip":"DIVISION SIGN"},{"name":"⁄","value":"⁄","escapedValue":"&amp;frasl;","tooltip":"FRACTION SLASH"},{"name":"×","value":"×","escapedValue":"&amp;times;","tooltip":"MULTIPLICATION SIGN"},{"name":"¼","value":"¼","escapedValue":"&amp;frac14;","tooltip":"VULGAR FRACTION ONE QUARTER"},{"name":"½","value":"½","escapedValue":"&amp;frac12; &amp;half;","tooltip":"VULGAR FRACTION ONE HALF"},{"name":"¾","value":"¾","escapedValue":"&amp;frac34;","tooltip":"VULGAR FRACTION THREE QUARTERS"},{"name":"ƒ","value":"ƒ","escapedValue":"&amp;fnof;","tooltip":"LATIN SMALL LETTER F WITH HOOK"},{"name":"∫","value":"∫","escapedValue":"&amp;int; &amp;Integral;","tooltip":"INTEGRAL"},{"name":"∑","value":"∑","escapedValue":"&amp;sum; &amp;Sum;","tooltip":"N-ARY SUMMATION"},{"name":"∞","value":"∞","escapedValue":"&amp;infin;","tooltip":"INFINITY"},{"name":"√","value":"√","escapedValue":"&amp;radic; &amp;Sqrt;","tooltip":"SQUARE ROOT"},{"name":"∼","value":"∼","escapedValue":"&amp;sim; &amp;Tilde; &amp;thksim; &amp;thicksim;","tooltip":"TILDE OPERATOR"},{"name":"≅","value":"≅","escapedValue":"&amp;cong; &amp;TildeFullEqual;","tooltip":"APPROXIMATELY EQUAL TO"},{"name":"≈","value":"≈","escapedValue":"&amp;asymp; &amp;ap; &amp;TildeTilde; &amp;approx; &amp;thkap; &amp;thickapprox;","tooltip":"ALMOST EQUAL TO"},{"name":"≠","value":"≠","escapedValue":"&amp;ne; &amp;NotEqual;","tooltip":"NOT EQUAL TO"},{"name":"≡","value":"≡","escapedValue":"&amp;equiv; &amp;Congruent;","tooltip":"IDENTICAL TO"},{"name":"∈","value":"∈","escapedValue":"&amp;isin; &amp;isinv; &amp;Element; &amp;in;","tooltip":"ELEMENT OF"},{"name":"∉","value":"∉","escapedValue":"&amp;notin; &amp;NotElement; &amp;notinva;","tooltip":"NOT AN ELEMENT OF"},{"name":"∋","value":"∋","escapedValue":"&amp;niv; &amp;ReverseElement; &amp;ni; &amp;SuchThat;","tooltip":"CONTAINS AS MEMBER"},{"name":"∏","value":"∏","escapedValue":"&amp;prod; &amp;Product;","tooltip":"N-ARY PRODUCT"},{"name":"∧","value":"∧","escapedValue":"&amp;and; &amp;wedge;","tooltip":"LOGICAL AND"},{"name":"∨","value":"∨","escapedValue":"&amp;or; &amp;vee;","tooltip":"LOGICAL OR"},{"name":"¬","value":"¬","escapedValue":"&amp;not;","tooltip":"NOT SIGN"},{"name":"∩","value":"∩","escapedValue":"&amp;cap;","tooltip":"INTERSECTION"},{"name":"∪","value":"∪","escapedValue":"&amp;cup;","tooltip":"UNION"},{"name":"∂","value":"∂","escapedValue":"&amp;part; &amp;PartialD;","tooltip":"PARTIAL DIFFERENTIAL"},{"name":"∀","value":"∀","escapedValue":"&amp;forall; &amp;ForAll;","tooltip":"FOR ALL"},{"name":"∃","value":"∃","escapedValue":"&amp;exist; &amp;Exists;","tooltip":"THERE EXISTS"},{"name":"∅","value":"∅","escapedValue":"&amp;empty; &amp;emptyset; &amp;emptyv; &amp;varnothing;","tooltip":"EMPTY SET"},{"name":"∇","value":"∇","escapedValue":"&amp;nabla; &amp;Del;","tooltip":"NABLA"},{"name":"∗","value":"∗","escapedValue":"&amp;lowast;","tooltip":"ASTERISK OPERATOR"},{"name":"∝","value":"∝","escapedValue":"&amp;prop; &amp;propto; &amp;Proportional; &amp;vprop; &amp;varpropto;","tooltip":"PROPORTIONAL TO"},{"name":"∠","value":"∠","escapedValue":"&amp;ang; &amp;angle;","tooltip":"ANGLE"},{"name":"ª","value":"ª","escapedValue":"&amp;ordf;","tooltip":"FEMININE ORDINAL INDICATOR"},{"name":"º","value":"º","escapedValue":"&amp;ordm;","tooltip":"MASCULINE ORDINAL INDICATOR"},{"name":"†","value":"†","escapedValue":"&amp;dagger;","tooltip":"DAGGER"},{"name":"‡","value":"‡","escapedValue":"&amp;Dagger; &amp;ddagger;","tooltip":"DOUBLE DAGGER"},{"name":"À","value":"À","escapedValue":"&amp;Agrave;","tooltip":"LATIN CAPITAL LETTER A WITH GRAVE"},{"name":"Á","value":"Á","escapedValue":"&amp;Aacute;","tooltip":"LATIN CAPITAL LETTER A WITH ACUTE"},{"name":"Â","value":"Â","escapedValue":"&amp;Acirc;","tooltip":"LATIN CAPITAL LETTER A WITH CIRCUMFLEX"},{"name":"Ã","value":"Ã","escapedValue":"&amp;Atilde;","tooltip":"LATIN CAPITAL LETTER A WITH TILDE"},{"name":"Ä","value":"Ä","escapedValue":"&amp;Auml;","tooltip":"LATIN CAPITAL LETTER A WITH DIAERESIS"},{"name":"Å","value":"Å","escapedValue":"&amp;Aring;","tooltip":"LATIN CAPITAL LETTER A WITH RING ABOVE"},{"name":"Æ","value":"Æ","escapedValue":"&amp;AElig;","tooltip":"LATIN CAPITAL LETTER AE"},{"name":"Ç","value":"Ç","escapedValue":"&amp;Ccedil;","tooltip":"LATIN CAPITAL LETTER C WITH CEDILLA"},{"name":"È","value":"È","escapedValue":"&amp;Egrave;","tooltip":"LATIN CAPITAL LETTER E WITH GRAVE"},{"name":"É","value":"É","escapedValue":"&amp;Eacute;","tooltip":"LATIN CAPITAL LETTER E WITH ACUTE"},{"name":"Ê","value":"Ê","escapedValue":"&amp;Ecirc;","tooltip":"LATIN CAPITAL LETTER E WITH CIRCUMFLEX"},{"name":"Ë","value":"Ë","escapedValue":"&amp;Euml;","tooltip":"LATIN CAPITAL LETTER E WITH DIAERESIS"},{"name":"Ì","value":"Ì","escapedValue":"&amp;Igrave;","tooltip":"LATIN CAPITAL LETTER I WITH GRAVE"},{"name":"Í","value":"Í","escapedValue":"&amp;Iacute;","tooltip":"LATIN CAPITAL LETTER I WITH ACUTE"},{"name":"Î","value":"Î","escapedValue":"&amp;Icirc;","tooltip":"LATIN CAPITAL LETTER I WITH CIRCUMFLEX"},{"name":"Ï","value":"Ï","escapedValue":"&amp;Iuml;","tooltip":"LATIN CAPITAL LETTER I WITH DIAERESIS"},{"name":"Ð","value":"Ð","escapedValue":"&amp;ETH;","tooltip":"LATIN CAPITAL LETTER ETH"},{"name":"Ñ","value":"Ñ","escapedValue":"&amp;Ntilde;","tooltip":"LATIN CAPITAL LETTER N WITH TILDE"},{"name":"Ò","value":"Ò","escapedValue":"&amp;Ograve;","tooltip":"LATIN CAPITAL LETTER O WITH GRAVE"},{"name":"Ó","value":"Ó","escapedValue":"&amp;Oacute;","tooltip":"LATIN CAPITAL LETTER O WITH ACUTE"},{"name":"Ô","value":"Ô","escapedValue":"&amp;Ocirc;","tooltip":"LATIN CAPITAL LETTER O WITH CIRCUMFLEX"},{"name":"Õ","value":"Õ","escapedValue":"&amp;Otilde;","tooltip":"LATIN CAPITAL LETTER O WITH TILDE"},{"name":"Ö","value":"Ö","escapedValue":"&amp;Ouml;","tooltip":"LATIN CAPITAL LETTER O WITH DIAERESIS"},{"name":"Ø","value":"Ø","escapedValue":"&amp;Oslash;","tooltip":"LATIN CAPITAL LETTER O WITH STROKE"},{"name":"Œ","value":"Œ","escapedValue":"&amp;OElig;","tooltip":"LATIN CAPITAL LIGATURE OE"},{"name":"Š","value":"Š","escapedValue":"&amp;Scaron;","tooltip":"LATIN CAPITAL LETTER S WITH CARON"},{"name":"Ù","value":"Ù","escapedValue":"&amp;Ugrave;","tooltip":"LATIN CAPITAL LETTER U WITH GRAVE"},{"name":"Ú","value":"Ú","escapedValue":"&amp;Uacute;","tooltip":"LATIN CAPITAL LETTER U WITH ACUTE"},{"name":"Û","value":"Û","escapedValue":"&amp;Ucirc;","tooltip":"LATIN CAPITAL LETTER U WITH CIRCUMFLEX"},{"name":"Ü","value":"Ü","escapedValue":"&amp;Uuml;","tooltip":"LATIN CAPITAL LETTER U WITH DIAERESIS"},{"name":"Ý","value":"Ý","escapedValue":"&amp;Yacute;","tooltip":"LATIN CAPITAL LETTER Y WITH ACUTE"},{"name":"Ÿ","value":"Ÿ","escapedValue":"&amp;Yuml;","tooltip":"LATIN CAPITAL LETTER Y WITH DIAERESIS"},{"name":"Þ","value":"Þ","escapedValue":"&amp;THORN;","tooltip":"LATIN CAPITAL LETTER THORN"},{"name":"à","value":"à","escapedValue":"&amp;agrave;","tooltip":"LATIN SMALL LETTER A WITH GRAVE"},{"name":"á","value":"á","escapedValue":"&amp;aacute;","tooltip":"LATIN SMALL LETTER A WITH ACUTE"},{"name":"â","value":"â","escapedValue":"&amp;acirc;","tooltip":"LATIN SMALL LETTER A WITH CIRCUMFLEX"},{"name":"ã","value":"ã","escapedValue":"&amp;atilde;","tooltip":"LATIN SMALL LETTER A WITH TILDE"},{"name":"ä","value":"ä","escapedValue":"&amp;auml;","tooltip":"LATIN SMALL LETTER A WITH DIAERESIS"},{"name":"å","value":"å","escapedValue":"&amp;aring;","tooltip":"LATIN SMALL LETTER A WITH RING ABOVE"},{"name":"æ","value":"æ","escapedValue":"&amp;aelig;","tooltip":"LATIN SMALL LETTER AE"},{"name":"ç","value":"ç","escapedValue":"&amp;ccedil;","tooltip":"LATIN SMALL LETTER C WITH CEDILLA"},{"name":"è","value":"è","escapedValue":"&amp;egrave;","tooltip":"LATIN SMALL LETTER E WITH GRAVE"},{"name":"é","value":"é","escapedValue":"&amp;eacute;","tooltip":"LATIN SMALL LETTER E WITH ACUTE"},{"name":"ê","value":"ê","escapedValue":"&amp;ecirc;","tooltip":"LATIN SMALL LETTER E WITH CIRCUMFLEX"},{"name":"ë","value":"ë","escapedValue":"&amp;euml;","tooltip":"LATIN SMALL LETTER E WITH DIAERESIS"},{"name":"ì","value":"ì","escapedValue":"&amp;igrave;","tooltip":"LATIN SMALL LETTER I WITH GRAVE"},{"name":"í","value":"í","escapedValue":"&amp;iacute;","tooltip":"LATIN SMALL LETTER I WITH ACUTE"},{"name":"î","value":"î","escapedValue":"&amp;icirc;","tooltip":"LATIN SMALL LETTER I WITH CIRCUMFLEX"},{"name":"ï","value":"ï","escapedValue":"&amp;iuml;","tooltip":"LATIN SMALL LETTER I WITH DIAERESIS"},{"name":"ð","value":"ð","escapedValue":"&amp;eth;","tooltip":"LATIN SMALL LETTER ETH"},{"name":"ñ","value":"ñ","escapedValue":"&amp;ntilde;","tooltip":"LATIN SMALL LETTER N WITH TILDE"},{"name":"ò","value":"ò","escapedValue":"&amp;ograve;","tooltip":"LATIN SMALL LETTER O WITH GRAVE"},{"name":"ó","value":"ó","escapedValue":"&amp;oacute;","tooltip":"LATIN SMALL LETTER O WITH ACUTE"},{"name":"ô","value":"ô","escapedValue":"&amp;ocirc;","tooltip":"LATIN SMALL LETTER O WITH CIRCUMFLEX"},{"name":"õ","value":"õ","escapedValue":"&amp;otilde;","tooltip":"LATIN SMALL LETTER O WITH TILDE"},{"name":"ö","value":"ö","escapedValue":"&amp;ouml;","tooltip":"LATIN SMALL LETTER O WITH DIAERESIS"},{"name":"ø","value":"ø","escapedValue":"&amp;oslash;","tooltip":"LATIN SMALL LETTER O WITH STROKE"},{"name":"œ","value":"œ","escapedValue":"&amp;oelig;","tooltip":"LATIN SMALL LIGATURE OE"},{"name":"š","value":"š","escapedValue":"&amp;scaron;","tooltip":"LATIN SMALL LETTER S WITH CARON"},{"name":"ù","value":"ù","escapedValue":"&amp;ugrave;","tooltip":"LATIN SMALL LETTER U WITH GRAVE"},{"name":"ú","value":"ú","escapedValue":"&amp;uacute;","tooltip":"LATIN SMALL LETTER U WITH ACUTE"},{"name":"û","value":"û","escapedValue":"&amp;ucirc;","tooltip":"LATIN SMALL LETTER U WITH CIRCUMFLEX"},{"name":"ü","value":"ü","escapedValue":"&amp;uuml;","tooltip":"LATIN SMALL LETTER U WITH DIAERESIS"},{"name":"ý","value":"ý","escapedValue":"&amp;yacute;","tooltip":"LATIN SMALL LETTER Y WITH ACUTE"},{"name":"þ","value":"þ","escapedValue":"&amp;thorn;","tooltip":"LATIN SMALL LETTER THORN"},{"name":"ÿ","value":"ÿ","escapedValue":"&amp;yuml;","tooltip":"LATIN SMALL LETTER Y WITH DIAERESIS"},{"name":"Α","value":"Α","escapedValue":"&amp;Alpha;","tooltip":"GREEK CAPITAL LETTER ALPHA"},{"name":"Β","value":"Β","escapedValue":"&amp;Beta;","tooltip":"GREEK CAPITAL LETTER BETA"},{"name":"Γ","value":"Γ","escapedValue":"&amp;Gamma;","tooltip":"GREEK CAPITAL LETTER GAMMA"},{"name":"Ε","value":"Ε","escapedValue":"&amp;Epsilon;","tooltip":"GREEK CAPITAL LETTER EPSILON"},{"name":"Ζ","value":"Ζ","escapedValue":"&amp;Zeta;","tooltip":"GREEK CAPITAL LETTER ZETA"},{"name":"Η","value":"Η","escapedValue":"&amp;Eta;","tooltip":"GREEK CAPITAL LETTER ETA"},{"name":"Θ","value":"Θ","escapedValue":"&amp;Theta;","tooltip":"GREEK CAPITAL LETTER THETA"},{"name":"Ι","value":"Ι","escapedValue":"&amp;Iota;","tooltip":"GREEK CAPITAL LETTER IOTA"},{"name":"Κ","value":"Κ","escapedValue":"&amp;Kappa;","tooltip":"GREEK CAPITAL LETTER KAPPA"},{"name":"Λ","value":"Λ","escapedValue":"&amp;Lambda;","tooltip":"GREEK CAPITAL LETTER LAMDA"},{"name":"Μ","value":"Μ","escapedValue":"&amp;Mu;","tooltip":"GREEK CAPITAL LETTER MU"},{"name":"Ν","value":"Ν","escapedValue":"&amp;Nu;","tooltip":"GREEK CAPITAL LETTER NU"},{"name":"Ξ","value":"Ξ","escapedValue":"&amp;Xi;","tooltip":"GREEK CAPITAL LETTER XI"},{"name":"Ο","value":"Ο","escapedValue":"&amp;Omicron;","tooltip":"GREEK CAPITAL LETTER OMICRON"},{"name":"Π","value":"Π","escapedValue":"&amp;Pi;","tooltip":"GREEK CAPITAL LETTER PI"},{"name":"Ρ","value":"Ρ","escapedValue":"&amp;Rho;","tooltip":"GREEK CAPITAL LETTER RHO"},{"name":"Σ","value":"Σ","escapedValue":"&amp;Sigma;","tooltip":"GREEK CAPITAL LETTER SIGMA"},{"name":"Τ","value":"Τ","escapedValue":"&amp;Tau;","tooltip":"GREEK CAPITAL LETTER TAU"},{"name":"Υ","value":"Υ","escapedValue":"&amp;Upsilon;","tooltip":"GREEK CAPITAL LETTER UPSILON"},{"name":"Φ","value":"Φ","escapedValue":"&amp;Phi;","tooltip":"GREEK CAPITAL LETTER PHI"},{"name":"Χ","value":"Χ","escapedValue":"&amp;Chi;","tooltip":"GREEK CAPITAL LETTER CHI"},{"name":"Ψ","value":"Ψ","escapedValue":"&amp;Psi;","tooltip":"GREEK CAPITAL LETTER PSI"},{"name":"Ω","value":"Ω","escapedValue":"&amp;Omega;","tooltip":"GREEK CAPITAL LETTER OMEGA"},{"name":"α","value":"α","escapedValue":"&amp;alpha;","tooltip":"GREEK SMALL LETTER ALPHA"},{"name":"β","value":"β","escapedValue":"&amp;beta;","tooltip":"GREEK SMALL LETTER BETA"},{"name":"γ","value":"γ","escapedValue":"&amp;gamma;","tooltip":"GREEK SMALL LETTER GAMMA"},{"name":"δ","value":"δ","escapedValue":"&amp;delta;","tooltip":"GREEK SMALL LETTER DELTA"},{"name":"ε","value":"ε","escapedValue":"&amp;epsiv; &amp;varepsilon; &amp;epsilon;","tooltip":"GREEK SMALL LETTER EPSILON"},{"name":"ζ","value":"ζ","escapedValue":"&amp;zeta;","tooltip":"GREEK SMALL LETTER ZETA"},{"name":"η","value":"η","escapedValue":"&amp;eta;","tooltip":"GREEK SMALL LETTER ETA"},{"name":"θ","value":"θ","escapedValue":"&amp;theta;","tooltip":"GREEK SMALL LETTER THETA"},{"name":"ι","value":"ι","escapedValue":"&amp;iota;","tooltip":"GREEK SMALL LETTER IOTA"},{"name":"κ","value":"κ","escapedValue":"&amp;kappa;","tooltip":"GREEK SMALL LETTER KAPPA"},{"name":"λ","value":"λ","escapedValue":"&amp;lambda;","tooltip":"GREEK SMALL LETTER LAMDA"},{"name":"μ","value":"μ","escapedValue":"&amp;mu;","tooltip":"GREEK SMALL LETTER MU"},{"name":"ν","value":"ν","escapedValue":"&amp;nu;","tooltip":"GREEK SMALL LETTER NU"},{"name":"ξ","value":"ξ","escapedValue":"&amp;xi;","tooltip":"GREEK SMALL LETTER XI"},{"name":"ο","value":"ο","escapedValue":"&amp;omicron;","tooltip":"GREEK SMALL LETTER OMICRON"},{"name":"π","value":"π","escapedValue":"&amp;pi;","tooltip":"GREEK SMALL LETTER PI"},{"name":"ρ","value":"ρ","escapedValue":"&amp;rho;","tooltip":"GREEK SMALL LETTER RHO"},{"name":"ς","value":"ς","escapedValue":"&amp;sigmav; &amp;varsigma; &amp;sigmaf;","tooltip":"GREEK SMALL LETTER FINAL SIGMA"},{"name":"σ","value":"σ","escapedValue":"&amp;sigma;","tooltip":"GREEK SMALL LETTER SIGMA"},{"name":"τ","value":"τ","escapedValue":"&amp;tau;","tooltip":"GREEK SMALL LETTER TAU"},{"name":"υ","value":"υ","escapedValue":"&amp;upsi; &amp;upsilon;","tooltip":"GREEK SMALL LETTER UPSILON"},{"name":"φ","value":"φ","escapedValue":"&amp;phi; &amp;phiv; &amp;varphi;","tooltip":"GREEK SMALL LETTER PHI"},{"name":"χ","value":"χ","escapedValue":"&amp;chi;","tooltip":"GREEK SMALL LETTER CHI"},{"name":"ψ","value":"ψ","escapedValue":"&amp;psi;","tooltip":"GREEK SMALL LETTER PSI"},{"name":"ω","value":"ω","escapedValue":"&amp;omega;","tooltip":"GREEK SMALL LETTER OMEGA"},{"name":"←","value":"←","escapedValue":"&amp;larr; &amp;leftarrow; &amp;LeftArrow; &amp;slarr; &amp;ShortLeftArrow;","tooltip":"LEFTWARDS ARROW"},{"name":"↑","value":"↑","escapedValue":"&amp;uarr; &amp;uparrow; &amp;UpArrow; &amp;ShortUpArrow;","tooltip":"UPWARDS ARROW"},{"name":"→","value":"→","escapedValue":"&amp;rarr; &amp;rightarrow; &amp;RightArrow; &amp;srarr; &amp;ShortRightArrow;","tooltip":"RIGHTWARDS ARROW"},{"name":"↓","value":"↓","escapedValue":"&amp;darr; &amp;downarrow; &amp;DownArrow; &amp;ShortDownArrow;","tooltip":"DOWNWARDS ARROW"},{"name":"↔","value":"↔","escapedValue":"&amp;harr; &amp;leftrightarrow; &amp;LeftRightArrow;","tooltip":"LEFT RIGHT ARROW"},{"name":"↵","value":"↵","escapedValue":"&amp;crarr;","tooltip":"DOWNWARDS ARROW WITH CORNER LEFTWARDS"},{"name":"⇐","value":"⇐","escapedValue":"&amp;lArr; &amp;Leftarrow; &amp;DoubleLeftArrow;","tooltip":"LEFTWARDS DOUBLE ARROW"},{"name":"⇑","value":"⇑","escapedValue":"&amp;uArr; &amp;Uparrow; &amp;DoubleUpArrow;","tooltip":"UPWARDS DOUBLE ARROW"},{"name":"⇒","value":"⇒","escapedValue":"&amp;rArr; &amp;Rightarrow; &amp;Implies; &amp;DoubleRightArrow;","tooltip":"RIGHTWARDS DOUBLE ARROW"},{"name":"⇓","value":"⇓","escapedValue":"&amp;dArr; &amp;Downarrow; &amp;DoubleDownArrow;","tooltip":"DOWNWARDS DOUBLE ARROW"},{"name":"⇔","value":"⇔","escapedValue":"&amp;hArr; &amp;Leftrightarrow; &amp;DoubleLeftRightArrow; &amp;iff;","tooltip":"LEFT RIGHT DOUBLE ARROW"},{"name":"∴","value":"∴","escapedValue":"&amp;there4; &amp;therefore; &amp;Therefore;","tooltip":"THEREFORE"},{"name":"⊂","value":"⊂","escapedValue":"&amp;sub; &amp;subset;","tooltip":"SUBSET OF"},{"name":"⊃","value":"⊃","escapedValue":"&amp;sup; &amp;supset; &amp;Superset;","tooltip":"SUPERSET OF"},{"name":"⊄","value":"⊄","escapedValue":"&amp;nsub;","tooltip":"NOT A SUBSET OF"},{"name":"⊆","value":"⊆","escapedValue":"&amp;sube; &amp;SubsetEqual; &amp;subseteq;","tooltip":"SUBSET OF OR EQUAL TO"},{"name":"⊇","value":"⊇","escapedValue":"&amp;supe; &amp;supseteq; &amp;SupersetEqual;","tooltip":"SUPERSET OF OR EQUAL TO"},{"name":"⊕","value":"⊕","escapedValue":"&amp;oplus; &amp;CirclePlus;","tooltip":"CIRCLED PLUS"},{"name":"⊗","value":"⊗","escapedValue":"&amp;otimes; &amp;CircleTimes;","tooltip":"CIRCLED TIMES"},{"name":"⊥","value":"⊥","escapedValue":"&amp;bottom; &amp;bot; &amp;perp; &amp;UpTee;","tooltip":"UP TACK"},{"name":"⌈","value":"⌈","escapedValue":"&amp;lceil; &amp;LeftCeiling;","tooltip":"LEFT CEILING"},{"name":"⌉","value":"⌉","escapedValue":"&amp;rceil; &amp;RightCeiling;","tooltip":"RIGHT CEILING"},{"name":"⌊","value":"⌊","escapedValue":"&amp;lfloor; &amp;LeftFloor;","tooltip":"LEFT FLOOR"},{"name":"⌋","value":"⌋","escapedValue":"&amp;rfloor; &amp;RightFloor;","tooltip":"RIGHT FLOOR"},{"name":"⟨","value":"⟨","escapedValue":"&amp;lang; &amp;LeftAngleBracket; &amp;langle;","tooltip":"MATHEMATICAL LEFT ANGLE BRACKET"},{"name":"⟩","value":"⟩","escapedValue":"&amp;rang; &amp;RightAngleBracket; &amp;rangle;","tooltip":"MATHEMATICAL RIGHT ANGLE BRACKET"}]');

/***/ }),

/***/ "ext_mod_id_1728986549046_37":
/*!***********************************************!*\
  !*** ./samples/grid-extender/image-data.json ***!
  \***********************************************/
/***/ ((module) => {

"use strict";
module.exports = JSON.parse('{"images":[{"source":"data:image/jpeg;base64,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"},{"source":"data:image/jpeg;base64,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"},{"source":"data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxITEhUSExMVFRUVFRgVFRcVFxcWFRUXFhUXFxcVFRUYHSggGBolGxUVITEhJSkrLi4uFx8zODMtNygtLisBCgoKDg0OGhAQGy0lHyUtLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIALcBEwMBEQACEQEDEQH/xAAbAAABBQEBAAAAAAAAAAAAAAABAAIDBQYEB//EAEgQAAEDAQQFBgsHAwIFBQAAAAEAAgMRBBIhMQUGQVFhEyJxgZHSBxQyQlJTYpLB0dMjY5OhseHwM3KCoqMVJENz8RZUg7LC/8QAGwEAAgIDAQAAAAAAAAAAAAAAAAECBQMEBgf/xAA/EQABAwICBggEBQIGAwEBAAABAAIDBBEhMQUSE0FR0VJhcYGRobHwFCLB4QYyQlPSI/EVQ2KSouIzgrJyJP/aAAwDAQACEQMRAD8A64JQ5rXA4HnCvYQQujIsVx6DoccDSnzyRrKOpfJRaTsvKsqPLZ/qGdOlSY7VPUVIi46wqLROknwSiRhoWnq4tcNxyWaSNsjS1yccjonh7c/VelaVskWkrIJGYPAJZvY8DGN3A5dhVJG59LLqnL6cV0D2srIdZufoeC8ruEEtcKOBoQcCCDiCr0EEXC517S0q51S046yTh9TybiGyDh6XSFrVMAlZbfuWxS1BhkDt29e2xyB7Q5pqHAEEZEHEFc64EGxXUNcHAELx7wqasmJ/jMVbsriXfdvzwOwHPpVpSzbRmocx6KqqodnJtRkc+1W2iJxpHRwDjWVouu4SsyceDhQ/5Lzxz3aB0xrgf0z/APBz/wBpy7FfPY2vpNXf6Ee/ArEwvfFJUVa+N2G8Oaf2/JesAskZcYgjxBXDnWjfwIPgQvbdGWxltsrX4c9tHD0XjBw6j8Fy1dSA60Lsj7BXVU8wljDx7K82ki8TtjopB/y9qPJSDY2Q+Q/hXKvQdi5oGYxfKbT051m9bd46xbyw3rOzVuY3/lfge1RWUGzWh0Eh5rubU5Y+Q/4da7+jrI9IUjKmPeMuB3hcrPA6kndE7L1G4++tUmtGjuTdfaKDb+y2Gm6iw6rtX3deu6g6fFssjS41kZ9nLxIGDv8AIY9qpKuAMeRuK6Oml2jMc965tKwGNxA6Wlea6Qo/hp3R7sx2FZSSDcLNa46N5eDl2D7SPygNrPOHVn2q6/CelfhKk0sh+R+XU7d45dtk9J04qqcTN/M3P6+Gax+rkRdaosKhpL+trSR/qAXfaYlMdHIeIt44LmYc7r0ed4Yy6TiRTiSc159YALZNmNslyyhZYCU+Bt+tDQg04ZbfzQACskbA4dawuk3vE0gdUOvmo68Pyou4ow3YMDeAVXLrNeQVoNVA50bjnzqVOVAB+6oNNnWma0bh6lb1Gxz23urpp/IkdhVIsxFjZFzkIxOS4dMyUjFNrh+hPwCu9AMDqok7mn6BaFe8tiw3lVsUhpmV24a3gqF0snSPiVMJDvPanqt4KG2k6R8Ur53lOw4JGV5/UfFK8d5RYJa7uJREh3lFhwRtH8SiJXbz2osOCNq8fqPiiJXeke0pao4J7aTpHxKdyzvSPaUtQcE9s/pnxKx+gbeGOuv8lxz3Hr2LLI24wXRi11ppDTCtK5cVgCk4gKMtx/U5FF0iAVQacsVwmVowJ5w4nzlsRu3KFjkV36paxGzSY4xuoHt4bHDiMerBY6qnEzesZLPSVLqZ9/0nPmrnwiaDBaLbDQggcpdycD5Mn6A9W5aNFOWu2TvfUrOvp2yN2zO/msIHgjNW2apLEFem+DHWAOZ4o93OZjHXa3Mt6viqfSFPY7Qd6u9G1OGyd3cls9JWCOaN0UjbzHihHxB2EZqtY8sdrNzVq9jXtLXZLyXQUbtHaRfZZCbk3NaTlWpMT+vFvSeC0fxRRCsoROwfMzHu/UPr3LBoyUwTmF+Ry+nLtT9f9GXJBM0UbJg7g8fMfoVk/BelPiKY0rz80eX/AOd3gcOyy1tO0YZKJmjB2fb9x6FdXgt07yc7rM882bFm4SAZf5NH+kLo9Iw6zNcbvRa2jZdV2ocj6rTeEXQIngcaY0oTx813UVxteDTTMq2bsHdY94eCunC4ssZC91tsl5w/5qy/Zyja8Dzusc7pDgsmiqpui6/Y3/oTfMw7mu4fTw61g0hT/GU20H52Z9Y94jvUZkM0IriRQHDaNvWF27mhrlyty4KDUzSZsNtbU0hm+zfXJtfJP+LqY7iVgqotpHhmFZUFTZ2PevWtYoL0d8Zt/Q5riNOUu0h2gzb6b+avXZLM2Ke66h8l2dVxMjbi4zCyUk2zfY5FUtk0H4vapZAPsyyse4XnVI6i3scF2z9N/HaOja4/1AbO7hge+/iCquvoxSykt/KcR9R3eifJIS68epVrBgqq9zdTtnTIQUBaSx1+uFOd0KBaSbDNR1i11wqvWQh0rHjHlGClMakGlewtXUaDlOxc1/6SffqsNY0vIcN60DZG2eJsbfKpTrPlOVFVVBmlc/j6blZtIhjDBmjBJgtSy1wp7LIC+nsmnaK/BAzWaB3zWVVrAbrg3YecBuwp+tV0n4fZZ0juweqrdLCxA71XwvXVByo3RldDXKd1i1E/+ZhLWT2R4jxRA6O1Gt1I2XWEqdCd1HU60kXRqdacxIlNrL71IGlLWUtkVmNb9BOsk5AH2TzWM8NrSd4y7E6WcSsvv3rq6um2L7DLcptBW4vHJPNXDFprmP2U5G2xWsMVduH83rAsi5pAKEHFpqCDlRSBUCFlLdZORfhi13kn4FbTXXUT8y22omsDSPFJqFjsGF2VTnGa7Ds49Kr66mJ/qszGfNWOjaoN/ovyOXJZrWzQjrJOWgVieSYzw9Hqqs9LUCVvXvWKspdk7DLcqyxTuhkbLGaPabwpwWw5ocLFabXuuCN2S930BpVtqgZM2nOHOHouGDm9q5yeIxPLV1FPMJow/wAe1Z7wlaueNWe/GPtoecwjyiBiWg79o4jipU8gadV2RSqIy4azcxiqjRVtZb7FdkoH05OQejKzbwrg7oK4CRsuhNK68f5QbjrYd307RdW7WNr6Wx3+R94rziUTRSc1rr8b8C0E0c05inFeuskbNGHtxDhfuK4kt2Uha4gEHjwXsmjdbrPPZ2mZzY3PbR7HkNIORwOzaFRVGjpHBzNUlpV3HXQuaCXC68/ttubY7c21McHQvPJTlpBbdcebJgac00PRULlZdHzSU76KVpDm3dGSLXtmB2jhv7Ft0tSwSazXAjI2VnpWxts8we2nITjCnktdn+/QSuk/DmljpCl2ch/qx4HiRuP0PX2ql0vRfCz67R8jvI+8R1X4Km0pZQ4OYRnkdx/n6roAVVNJY5eheDvTXjNk5KT+rB9k+uZbTmO6wKdLSqaugAceB9ldLSTbSPsXNpiyFji3diOjYvNqymNNM6M5buzcsjxZNieXtAOxpHaT3QtiihDWE8VqVkxmIYdzbe/JVk8VCtwYKptY2K5TgVNMqVkReLozIootNnA9aiGlxsFz2ixhtossANeTZeJ30dWvQXBXHxB2M0nSIHj9lsOiGuxo3Y++9SuLi4udn+nBUrRZYNYk3KmjmomQnddELzeDtyxPwTYbOBUGsD6vZ/Z8Sut/D2MLndf0Wjpd13t7FwxNXSNVI4rpAU1hKNEJJzKbkiFNrrZhOJ4IQT1IYIxUbhIJqNyE6g3pKWHFbHSNihttnukhzXtvMcMwaYOCo45HwSX3jNenSRsnjscjkvGbVZZbPKY31a+NxFejaK5groWObI24yXMysdG4tOa0ejrWJW3sLwzG0Hf0LC9uqUhjmpXNBrT9kksL4KttTLwLHAloGOWB2O6VkbhisesQexUlx0brrsxTEbdzgswNwpOG8L0XRxbpOxOhlI5aPJ22tOZJ14g9e9VEzTSzB7cj7IV5TSCrgLH/AJh7BXnc9mdG90bxRzCWu6R8FascHNDgqWVjmOLTmFpPB/p/xafknmkUxDTua/JrvgtWtg2jLjMLcoKgxSY5HP6H3uWt1909aLO5jInCMPbW+Wh1TUgtG6gp7y06Kniewufu67Lc0jVTxyNZGDYjdn3YFeaWgPLvsLQx4kNZLt2ItkJxvtBNen8lu3DQXBgJGVrEnqGS07tvZznC/SuAD15hDTdlNnYx5cJATRxBcKHZ52O3dktOg0xJUSvjmhdGRle+I8B9Vs1Oi4o42yQyh4OdrYeqbq5pu5IGxMY58hDQJBWprgAXHCtd6spRFI35iRZa0QniPy2Ph9lZ606PmlBdLZHROpRzohVrh7TBWq0g2G+Evy8CLj6WKzyGf8zmAHiDb6lT6sWy/ZxYpi8gc2N7o3C7SgZUkbMugLn59Cz0lb/iFGRbNzcRcfqthbHPtW+NKU9TB8LUizjgCCDjuyN/LJC0tddLX4Oj5jujzT0ftvXTRTRzMbLGbtcLhc5LG+Jxjfm3A/RLV63GyWhlpr9mfs5/7Hef1Gh6kp4tqzV37ltUFRsnY5L0/WKzh8fKNxoK8C0/yq4bTlJtItoM2+m/wzXRSC7bhZvlLppwAPYPiqyIajQOpUcklpSnWiO8OP6hZXBORmsLhVkkRJoBUlRC1bEmwVlZoxGMT0lSAxW5G0MGKy2rOkHWm2TSujLWtbcbeI9LACh3Ak9KsasNjgZGMzipC2ve97rR2yHGu/Hr2qrKwTs1XX4qvIxUlhVjYor3RtPwCiGaxWWKIvN9yptNWj7UUa880UugEZkbSNy6rQp1YXYfq+gWlWwiWS+sBh73psUo9CX3R3le7W2Y9eSrvgg78rx4jmpxIPQl90fNPb9XkeSX+HnpDxb/ACSEvsSe5+6e2HDyPJQGj3H9Q8W/yTg/7uX3P3S249g8lMaMeciPFv8AJOD/ALub3P3Rtx7vyQNGO3keLf5I3vu5vw/3R8Q33fkn/hUnEeLf5Ihxr/Tmp/2zXsT+Ibb+/JQ/wuW+OXaD5X+qdePqpvwyjbsS/wANm925qLVHS8lim8TtGDHO5hOTS44EH0HHsPWtLaQ18AqYDf3iD1hdhC6Skl2EuW7n2FaTXbVwWqLlGYTRjmn02jEsPw/dQpKkxOscitispRM24/MF5PZ7U6J4duNHA7siCr1wBC54N3LVwyte0Pbt+GdVrkWwKh1jNNeAchTHdmdvSjJAIK4LZYr43EeTTZv7VNr7FPVO5c+r2lnWeZsgrzTde30m15w/m0BSmiErC1ThlMEoePYWs130U20xNt1m53NF4DMs309Ju0buhVtJKYXmJ/v+6t6yFtQwTR4+/ULzh7qq0JVOBZb2xTf8V0e6yl920w0dG6pBN3Kp4g0PSDsVXOzZP1h+V2fUc1b00m0bsz+ZuI6xl9vArze2asOhvMma6Mk5vYRlkQ8G67pBWq6NxxGPYt9srRgTbtwVnqlYppH8mHGRlKOJBLR21FKVwWJ+kJNHwvlmN22+UHe7cB9bZLDNQwVsjGRizr4lu4WzNu6y59MWiaAOY1rY3Rv54Y1uDdjhhkd/EK1FXtqds1Pkce73mqxlExlSYqgk2yuTn/bJcVj06+UABzq5HH81qfEzb3Kx+BpsgwLss1tkiJe8ukZGY3EnNov841GfNxosTquYwSRudi4arSeJBw8FiFHAypjLRkbnsGXmvSdZLI24y0sxF0Nkp5zHeS7tI7RuXN/hDSLg59BL1lvUf1D6+K3PxBSAgVTd2B7Dke5ZqzGhdGcRjhmCDu6l3hxxXKtJabLdah6UvsdYpTV8bax1zfCcuktrTsVTX04/OMjmuioJ9ozUOYXBpWMiR/SuKc3VJHBVtQLSFQWa3U5rupAUI5tXArqEoFSaAYY7/mi29bF2j5lwzyOeccGjIfE8VElar5C89S4dW4RHFUZuke8nfVxp/pAWWqlMkl+AA8PupF51rjctA4hzfzWG11ukCRmC5m2QE1ceofEoAWFkHSXRJJhdH5bFLWACyySBo1Wqj0kz7Wm5o+fxXX6Db/8AzA8SeS5zSLv6lupPaxX1gqkuTgxOyjdGiEXTgndRRCEk4BCE6idlG6N1FkXTbTDHpKyB7QGyDyfZeM213H4grzGCeT8P6SMLzeI+bTk7tC9gkjZpKlDm/mHkd47D911ah6yE/wDJzmk0ZLW1zcG+afaFD0hdvVQhwE0eLTj47+9VNHOf/FJ+YYeG7uXF4R9WgAbXCP8AvNG8k/afnQ9XFZ6Gp/y3d3JYa+l/zG9/NY7RGkOTdQnmOz4bKqyc24VMQtNyg6jSiwWUdbFAx7RtUSsjeIWf09Hc+0b/AJcRv6QsjJLYFS1NbBWWoOtYgl5KR32Upxrkx2Qd0HAHq3LXq4hK24zC3qF5hfqn8p9VB4RdXzZpOViFIZTs8x+Zb0HMdYUKWo126pzCy1VMGO1hkVQau6WdZZ2TA4A0dxH8/UrZe0PaWnetQlwIczMYjl3r3+ySRzRtkbQtcK7+pUT2ujcWq+ikbMwOGRVRpexNieJ2CgIuyhozaMWupwNepxXNfiKJssQLnfNuuc+I977DerKhNjqgYLEa9aLvNbamDc19M6ea74dYWx+DdJ2LqGQ9bfqPr4rQ0/R4Cdu7B30P08FmdVrNZjamNnjaWPN0nyaE+S4ltCccMd67ioj+QloF+wKhp5fnDXE2yzK9U1g1Xh8WcyONrAAahopUHOu9cdpYPc1s4OLPRXYia0fKFl/B1ab0M2j5sTAborm6F9bvZiOoKh0teGoh0lB+rE9ThzH1VhTls8ToX8Ldx9+iq7VAYnuY7yonUrvafJP84L0qmqWVMTJ2ZOF+Y7iuIqIHQPdG7Np8txXXpGSSzCK0sF2SPntr57ac5hG4g/mkJI5ddgN7YHqK2mMkpyxzha+IvvWkNvjtLG2mI1bKL1NrXecx3EOr+S4rSNOYpj14rPVt+bWG9cs1mqtBaLm3C5obKQRjUCtK7KpLGAQLLomIa0uOAaCT0DEoAubLI1tyuGwwkRMpuBx44oOJRuU8VrIq0jaKca7uxMLLFKW3vkusPwoEErI6YuywUsYAULLGFSOkvyOfsJw6BgPyC9C0fAYYGMOYHnmVztZJryEqcFWC0SnVTUUkITqoSRqhJEFNJPCaSOCElhdW9Mmyyh2N11A9u8bxxGf/AJVRpvRLNI0xjODhi08DyOR8dy9B0fWOpptb9Jz99S1GtmieUa23WUnlBdeSzNwGIePaGHUuR/DelpKaU6Oq8BiBfcej2Hd91faTo2ys+JhxOeG8ce0LU6paxstsFHU5QCkrKUzwqBtaV1FRAYnXGW5aUEwlbY5715/rjq+bJJVgJheeac7pzuE/pwVpS1O1bY5hVNZSbN2sMkzQGkD/AEnY18iv/wBf1WaSwGscFo6jnGzRcnctNHBGRg51RSt2hxNatFVSP0k7WOqBZdDFoNhYNZxBwy8xkuK16LsznAySOdWtW3qVGBzA3HoWF+kZHYCwW3FoWJmJuffUvMJxycz48aNe4CudAcK9Ss6ebWaCVW1MOq4gbl61qZphlusrrJaOc9jaGuJczzXj2m4CvAHateoYYn7RqzU7xKzZu9/2WC01ol1mmdC/EDFrtjmnI/DpBVhDIJG3CrZ4zE6y3fgz1g5NkkMn9ONpkv7GgCmJ6BTqVZpqWOniErs8gN7juA6/otnRRe6UxgYHG/A/dVukfCXelc4ODI2m6GlodfG920dAIz2rlxo1lS0yVB+c8DgOoDh255rojIYzqsWk0JNDbLIbhrG+82hzbiRd6QRgdoodq5eZ02jq8SDNpBHA/wBxyW6/VqIrOyIsV5vpOxuglfG/ymmnSMwR1UK9koayOrp2Tx5OF+Y7iuBqad0Epidu93XsWqWmvGbE155z2t5OQHa5opU9IoetUukItmXADAjBX9C8TNbrHqKwGmon2S2RW9lTFXk7RTzY3HynjcDQ1XMQ07ZqWSkO8Xb1OGXJWL6V9NIHjFvHqWi0zowSWmKYULLp5TaCB5HTUkDoCj+HtLuho5ac5jFvVfA+GahV6KFRUxyHL9XWBiOXYqbWuN0hjFaUBJwzvEYDhzc10Ohy5sTzxPp/daWn2tfMxvAHz/sqXRNrbZZS2PnRuoXAHyT07SP0NNy3a2mFVFq/qGRVFLM1gsVtbNaWPaHAgg7f5kVyEsL43FrxYrFcHEKYMWKyAs1rraSYTZ4/KkFHn0WecOk5dBKtNG0LpX65yHr9k2zNidcq6hAcxpGRAI7FWSRmNxadyhe+SdyKgmApGxJqdlwaTmw5JpxPlHcN3Sf0V7obRxkdtnjAZdZ493qtGtqRG3UGa5oogBRdeG2VC55JUoap2UCU4NTSujcSsldIRosjWS5NFkaycG8U7JEp9FJRRohFwslrxq94jKfUvJMbs6eweI/Mda1aeqbI3HPeu8qaV0bsMty6dR9ZGxu5F5+zcRcNfJcTt3NP5HrXL/ijQnxjPiae2u0YjpAfUemHBWeiK8wHYy5E4dR5H1XVrFZX2C0MtkGDHOo5vmgnNhp5rv1HQpfhvS40hTmmmPztGfEce0b09JUhppdvHkc+o8itsJYbfZNtyQUOV5jgeORBVidank6wpDUqIuorzrRmi3w2uSKQAujiLhTI1IAc09BK2q+oD6cFu8rDoylLKg624K/fEa5AXnAmtfNJce0BvYeFefIuuma4DFO0ZZAZ2mTGMVDQKEc0mra1rTE8MhkmAG4lJ2u8WYO9R+EXU6Gezm1WVv2rKFzWec0A3hdHnDZ0U3LcpqgA2Bw9FV1VK61yMR5heaataYfBKyVp5zDiNjgc2ngVcjVlZqlUjtaJ2s1etaY0fFpKytlhIv5xuOw+dG/d/wCCq01Ioi50ps0ZrffEKpg1c9yz2vNkfYNGNbC0uvyN8YkA4GhdubeAA2Zb8eQp686V0ltJsAAdRvfj/wC1s+QCsmU4pINVme8+9y8pMt/EVLiaUGJJOVBx3LqNRrB1LWDnOzzXvXg/1afZbG10lQ91XObuL6YHiA1o6by5fSdH8XDJUNHDV62jPxuSOqysIn6hEZ7+1VPhH0ZUNtAGI5jujEtJ/MdYW/8AgjSH56Nx/wBTfqPQ+KqtPU+DZx2H6cu8KPwZWt8U5jd/SmFKnAXx5Ge/EdYXaaQjDo77wqjR0pEltx9VsNMWQseXAEg4uHA4ZbRiuLqoNR2sMl2tLPtGapzVeKht1vNaMebwwwAyAzy2FagaGknitqw3Kl0jod85/rBjKUuNZUnZUm9tOzLFWdNpAQR6mqqiv0U6qkLw+27Jc0upsl08nLGSMgQWDKvlY027Ni3WaZa4huqe5U0v4bc0F208R91T6NbaIjW6R0PbTrBzVq+nbILSNuuVfNGfyOt3FWo0paKUuH3o1hGjacG+ofH7qAnJH/kHgeS43Xya8k6pzJezHrqt4DVFg3DuWH5ScXjwPJd2jNJSR0Y+J12uBvRm70i9WnQqTSGjjM7aMaQd+WPnmt6NzALbRvnyV4zSMfpD8/kqj/C6roHy5rIJ2ZFwXHadJyGojjIHpF0YJ6BewVlSaHDTrTgnqGXeiSZpb8kjR235LkZynq/9yLvLomvDRYMPgOaqnUocbmVvieSlAk9X/uw99SE3+k+CRoW/us8fsjWT1X+5D31Lbf6T4KJoW/us8TyTr0nqj+LB9RG3/wBJ8EfAt/dZ4/ZJzpPVH8WD6iBN/pPgk6ibukb4/ZASP9U78SH6ie2PRKiKRv7jfH7JwMnqj+LD30tseiVIUbP3G+P2TQ93qne/DTt5RS2juisYp2XttAnC96p3vw/URtT0VL4aPfIPfepQHeg734PqqO2d0ffgp/Bw/ujy5rQ6Y0bFaozHO3lGnYSRQ7CCMQeheYM0hUtdrB5uvXzDGRYtFl5xrD4MnMrJYnl1MeSeed0Mft6D2q8ovxAQdWfDrH1HLwVfUaMa4f0/A/QqfVbWdsrDo63tLJKXGl+BcNgNcnCmB2qu0lSPpqgaSocr3IGXX3HeNyy0w2jDTT55Y7/uNyboi2yaLtLo5KuhkzI2jzZGjeNo/ZdnTVMWk6YTRZ7xwO8H6eKoHsfQzFjxh6jit9aoI3OEwAJLCGvGN5ho6nEYArRlJDdU8Vaw21g4Ktt9rbGx73R3jHgTW7cqMCdtaVOG5akmDSt6Jus8BYHSWmZ55BdJYyvkNNL3F5Gf6LVJFlagL0vVN5DG1FBShChAdR3UsVUNdvWvKfCBoWOz213IOFHc8sH/AEyTiOg5gbAV0dK9xF1yNa1jHWvnjbgr7QmnYtFwls5e6WUtdyDSBybaYF9fJe7Dm50Da0XNabMulZRDTkbNubtzndXEDjle+eC39HxfDR68mZ3cPuV26w2u02iJtusMz7jWlkkBoW0zcHxGrXOx6xlxx6J0bThjqWqYNcG9+o5FpwIH1GKyVM0mEkZw4Km8H2nofGmmWy2Zjq4OihDDSmNMTQ7cKVFV0LNCxFhDnPdwDnEjvG/vuqmfSUkb2uAAbkbDHtXuZa1zRShaRhTIhY3N3Fb7XXxCzum7RBFFJ4xUNGGRJId5JaAM69i56HRUlLVtkpW3N7jgOIPVbvWzLOx8REuW9eVS6Uc94EYJZtceacDgKbDTsoM13bpHlthYG3bY+S5R744zcm62NhtFpmAkmkccKMZkKEeW4Dyif3XK6QnDLwg3O8/QLqtDwSygVMmA/SPqfp4rrgtILnRhwvNFSBmMTXEYYU6qhaJhkawPIOrxVs2qhfKYg4F2ZCoNaNIWiBzOTcy46oLroc4GpwN4kZcPNK3dHwQzkh+JHXuVXpirqKZodHgDvtvUkdpke0XnudUDM4ZUyyXWwU8UY+RoHcvNKuuqJnHaPJ7SbeGSdcWey0bocmiyNZHk0WRrIckjVT10hEEaqRepGsTsokp4CkAolOATSRohJBCaSSEEkJyaSNE0IoSRQktcvHV7ogUimqTWXVuG1tAfGb4xZI0hsjDmC13TsOC2YKmWA/JkcxuPaEixj/z93Edix2seiLRyIjlqSyvJy0wyycMaVwrTDDqW9o2v+EmMkQsHZt5dm5Kro2Vceq44jI812eDuS0SWGZpP2kUxiiDjQNvMaSCRmKvXRVdQHkPZvCraODZgsfuKvNYNGBkIs8eAvXn1JJc4gFznE+USTWvBV8j9ytoGgi/vNZOz6NpIKHI7sFC6z55LcMtbbPA6V2QGA9I0wAWanidI4Ab1qVkzIYy9xyWDMLoIJdKTtvvL6QgirXTOPlkeiytacKbFt6VldeOhiw176x4NGYHW6+J3A9a5ehj2j3VMuQy7ePdu+y8u0lanyPL3uLnOJJJzJOJJ4qUEbYm6rRlgt6RxeblepeBa1Hk5I5XgNlkDIQfOcxpLwOi+wddFiLTJVgtH5WHW7yLehKWsGMs45nBSa/amvsrjabMTyZdUigrG8nCnsk/JXlNMXDV3jzVZVQNBuRgVqdU9f4W2RvLUbIyrXMrQg1reFcbpBrhXGoFVjlgMjrhRinEDNSxI3Kn1g1itNvDoweShOAuVF5tdrjznVGzAY5LOykY0dfFV9XpZwNh4c1zaP0fGwsF3mAi9TMtrj10WV0R1CGZ2w7VSMqg6ZrpcRcX7N6ubdby6oYLjTgfSI3YZDox4qqo9CtjOvMdZ3l91f6T/ABS+ZuyphqN47zyVWyAtIcw0IyIVu+Fr2lrhcFc5DVyRPEjSQRvVw1jLVG6J1GuIyOADhS69u8AjLdgcFy0tDLRVDZIwS2/ruK9AptLU+laN0UpDX28xvH1Cr7LGQ1oOdAuvaMF5nI67jZTUUrLHdGiLIuhRFkXTrqdkXQupWRdKiLIRTSRQhJCEU0kqpISQhJCEqoQjVCEqpJLXrx5e5pEJZoySDiMj2ou4b07ApkjrwIc0EHNG0IN7JhtsQVV2TR5gfWGgY4lzmH0qAC6dm7GqtaeuMbccW+nFN7GvxyK4RrCXTujtUDoHH+mXOD4pAMObKAOdtoaKxbM2ZpMZueG9Y2O2fynDr3e+1c+m9JNhjdK2J0l0VoylRxJOzfStFsw075DuChNWxxjisAdapbTIOVo1mTGDJp4k5k7/ANF0NJTsiGGfFcnpSoknx3DctXHpQvh8VlYyWGlLrqggZgNcMiDiDStVpVWgIZqj4pj3Mk3EG48DuO8XAPetOn0xLCwQloc3rwNu0clmLdqXZnSB3LSBgGLLjS+m7lL1Ou71LBFRVwcQQw3/AFXNv9tr92t3qyfpOm1AbOuN2Hr9u5WH/CyXtaxt1jBRrG+YwY0BzrUkk5kuJVzSQMpWFoxJxJOZPHkMgMFVTVL6lwc4YbgNwWn/APXMvJizmyid1Lpe8lsd2nnilXO2HELBJTf1LsWydIsji+f+6o4NGtvF5ABJJoMm1OQrjTpK3msO9czPWuebDAKxYwBTsFolxKeAEKOKdRSUUqIQjQJ4IxTgUXUUaoQinZCCEJIQkhCSEJAoRZG8hFkr44ouiyXKBF0tUpXwi6NUpX+CLo1Ug9CLI3kIsjVNKyNQhKxWlsOkI5mX4nh44bDuIzB6V5DPTyQO1ZBY+8uK9wgmjmbrMNwpROLwacCctx4dKwrOWYXCmohY00hCkgW1Czw5WRexXNarO2RhDgCOOKx3LHXCmDY2XBYrOG4ZtyIONP2V5Q6RuQyTPiterpBa7Vgte9TRCfGIMInHEDKNx/8AyTluy3LsKSYSixz9Vy1XEYsQMPRceg9IXgIn4PGAPpDhxVi08VQVMNvmbl6LWWbRTn0Jwb0YnqWN8gHanHA5wxyUttcxjQyIAyNOeJa07zQguPDt3LFZzjdE1VFANQYlcHKPJqWQknMkS/USEbx+o+XJaT6yJ5u6MHvdzUjXu9XD2S/UUxG/penJYfiYP2h4u5p4kd6EPZL9RGzf0vTkkain/aHi7+SV5/ox9j++paj+l6clDbQ/tjxPNG+70Yux/fQGv4+iRkgB/IPF3NOBPsD/ABf30HaD39lIOpjmLePNOB/t913fUf63V77lK9GBvPd/2Sv8G9ju8pHa9XvuUQ6k4O996F7+3sco60t8lLVoyMyhfO5va4fBT15OCxltNxKe6Tg33nfJIOk3qTm0u768lGXO9jtd3VPaO4LFsoen5IXnex2u7qNo7glsoun5I3nex2u7qW1d0U9hF+55FNvu3M953cRtHdFAhi6fkUCXbme8/uI13dFMxRbn+RRBduj95/cRru6KBFFfGTyKPO+796TuJbR3RT2MP7nkUud7HvP7ie0d0UjDEP8AMHgURe+795/00bR3RRsIv3B4FLn/AHfvSfTS2r+h6Jinh/dHgeSIv/de/J9JLbP6B8lIUsB/zR4FOF/7r35PpI27+gfJHwkG+YeB5Ihz/uvfk+kltpOh6c0Clpt8o8Hcl53ovSktnffjcWkGhGw081w29a5+WJkrdV4uD7uF20T3MdrNNnD3Yr2Hlm2iFkjDg8B7Ttac+0HA9a4maN0RLTmDZdlTSBwDhkVNHpAjmyCjh2HiFiBWQwA4tyUvjrd6ahsSpLPagXU3qcZs5RfEQ26U77oNU5EMbrFV+jpKvduStgtiYWarJ1na9rongOY4ULTtBXTaKq3PbYn5m+wqKshBxtgV5hp/QJsL2hx8okwvwN4DcPSGFeldcypbI2+S5OenMLjdXsOkZZGNBAZVoD7vnHafZHD81NkYzVJV15/KzBANCzKpuldSsi6ICkErp1E0rpUSsi6VE0JIQkhCCVk0qIsi6CEIoQkiyEqIshC6lZF0rqLIujRNF0aISSoiyEqIQnAISujdTsldG6iyV04NRZK6N1FkXTtadT4rRWSP7ObeBg/+8DPpXl1HpKSn+U4t4cOz3Ze2T0cc+Jwdx58fVVeqMdtstYbRZ5DASS17KP5MnM3WkuuHPKoOzE02q11PU/PG6zuBwv8AS6w0m2g+R4uOI95K3LbYZHxvh5SEm9DMxzKhpxuPFa4VoDTYtCWGMxtczB28fUfVWNNKWSEOy3H6FJmjLR6BHWPmtfVct/bx8VYWGwPa5rnYUNTjX9EBpBusUkzHNLQujS76xE5EEHtqEE3Cx04IehoWyFrbxzOKV7pVD74BR622+Sz2aSaK6XsbhexbSoqSNtASepWGi36tU0HI4cvNV1VfYuI3YryKxzS2mflZnukec3ONcNgAyA4DBdzCzFcPXznUN1t4BQK0C5R5uVKmoJIQiE0I0RZJKnQiyEk7ISRZCSEIJJoIQlVCEqoQlVJCVUISqhFkqoRZGqaE4JqKKLIRQknAIskiE0k4ISSqhCNU0rLUxvLa5HavG2vLcF7u4ByLrQ7cEOkckIwqefSVrjlFYWSQuNL8ZN9lfTYa1HtN6wtmIxOZgbO4HI9h3dhUdUh9jlx3ju3hd0ek6vuOZdr5Lq1BPonDA7s68DQGTj8txmpvhLcb3CltMxGNBRYNqVONgKgMYkF00of5UKJc5yyX2ZuFYtCAtUm6z2v04bYpa7Wkdouj83Bbmj2l1Uy24rDUODaeQnh6rzvVmyecV6LTs3rzTSEv6QtSCtxUqN5CLBEFMKNkQf5gpJI1QiyVUISQhCiLJoVQhCo3pYJ2KFRvQjFIIQiUIQ/m1CEUIQJSRZFCEQmknAppWTgU1GyNUkWRvIRZC8hFkQ5CVkb6EaqV9CNVa5eOL3RMIQmgkmmz2cOGIrsK2IzcdYTDrYLlsoka0skdygxuvpR1NgeNpHpDPaNphI5t8ren2Q1tjgU3R0vOI3FJZ5hhdWxcAKnJO3BaS8/1unda3iNhAja7nVFQaZCgIrjj1BdZoTRUjRtX4E5Ll9N6bhjGxZ8x38OxKywljQAI/cd9RdSyN7f1eQ5LiZauF5vsx4u5qYF26P3X99T1Hn9XkOSxieEf5Q8Xc06rt0fuv+ojUf0/IckfEwftDxdzRq77v3H/AFUtSTp+nJS+Ip/2h4u/kiXO+791/wBVAZJ0/Tkg1FNlsh4u/kjePse4/wCqjVl6XpyUhPSft/8A1/NK8d7Pcd9VGrN0vT+KDNSft+v80Lx3t9x31EWl6XpyS2tL+36/ySx3t9x31EBs3S9OSkZqT9v1/mgCfY9x31FINk6XpyUDNTE4R+v8kif7Pcd9RLVk4+nJPa03Q9f5JpH9vuu+ojVk4+/BBlptzPX+SBHFvuHvpWk4+/BPa0vR9f5JXeLfdd30DadXvuQZKU7iO7/umkO9nsd3k/6nv+ygH0/A+/8A2Tau3M7XJ/PxUQ+Efp9+KHP3M7XfJS+ZQJi4FSUd7GW93yR8yCYutLn7me8e6n829QJithf33otL9zPePyTu5L+nff771KHu9FnvO7qXz8VPXg6JR5R3oM953dR8/EI14OifH7oiQ+gwf5P7qR2nFSDqc/pPigZT6DPff3UrycUE0/RKV4nYz3n91Gs9Fqc7yO77oc/7vtf3Ua8lskalMT+Y+H90brvuvef9NQ2kvAe+9ZdnSdI+f8Vdw24s5r6kea7huPFeRg7l7c6EOxaurx1u9NYti5MdbW70KQhKdY7c0vDa+V/5WWHB2KjLCQ3W4I6RkuCuytE5gL4IgGssxLonxl7nMfJC7ZJE5zHVGVbp5w4FZYZzFuBHA4hZKmNrm4mx4hYjT02kIZTBaJ5XUyq43Ht302jgV1dAKaRoliaL9mIK4zSDqiMmN7jY+YV/oKcOYF0kJuFw1bGWuVuthaCSEIoSSQhAlJNJCEkIQqhCVUIRqpISQhBJNJJCSEkU0IgISRomknBO6EihJCijZO6IKkkkEkIoQh/MkrIQqlZNG8miyFUWQtFZLsgvNoWnMHMcCN68nrKKWml2cgx3HcRxC9totJQ1kIliPMHgVFNoVp8k061gDXLfbU2/Mo26AO1yyCNyZq27gumz6LbGbwxIyJ2dSNmQoOnLxZMt94sc0Yk5V38DtUCRkSpRWDgV06NsfJsA20x6Us1hlk1z1LO+ErRjZLLylOfEag7aHyh0Ux6grbQ8xZUBu52HJVWkohJTuO9uI+qxuq7XUOdF3dOCvOtIltwtLQrcsVUYIiqMUsEsU0YJVO9CMErxRcosEqlK5RYIYoxTwSxRijBLFGKMEaKSSdRSsldCiSLo3ErI1krqLJXRu9KdkXRuosldG6nZK6cGosi6NE0kCEWRdNISsFK6SEIJITSkpIUSQlRCLpIQpbJanRuvNPSNh4FaVbRRVcezlHYd46wt+g0hNRS7SI9o3Eda1NhtzZW1bgRm05j5jivP6/R01E+zsWnI7jyPUvTNGaVgr2azMHDMbxzHWpy4qv13K1ACaQkSTmmi1qVkiVKE1BZPwg277IWduL5DToG0nqr2hXOhaV0tQHbgqzS1UynpnFxzwVNoyyCNoC9BjbqheW1ExkdddtVkutZGqd0JVRcIslUIwQhVCaSEJVQhCqEWSqhCVU7oRTQhVRKE5CSITuhKqLpI1QhKvFCEetNJJCEEJoUSshKiEJIQghNJCEEk01Fk1B40/wD9s78dncWptJeHl91Z7Gjy1j4j+KdHbpGm82BwIyInZ3FikJlaWPbcHMW+6zxMghdtIpCCMjf/AKq4sOszyaSwFo9Jr2O7W4fl2Ll6v8PknWp/A/Q8/FdXSfiKMNtOR2jlyVxHpSA5SNHTzf1VTJomsZnGe7H0VvFpiik/LKO/D1Upt8IxMrPeHzWNuj6pxsI3eBWZ2kKVouZG/wC4Kq0nrK1gpCx0rt9Q1o63Z9QKsqbQFQ83kFh5qrqPxFRx4MdrHvt429LrOutLnuL3wOvHaZW9nkrrKWm+GZqRtHvvXIV1dFWSa8rj1AHAdnyqVk1f+lTpmb3FsmSUbvL7rTbDSO/UfH/qnseT/wBMDpmb8GJ7WQbvL7pCnpT+q3a4fxTxXcz8X4XEtvJ0ffin8HTWvtB4/wDVIk+g38YdxAnk4eX3TNJSj9f/AC/6o4+rH4zO6kJpeHkeaZpaW2D/APkP4oDjHT/5o/kh08oyb5HmpMo6Q5vt/wCw5Jf4dksSgaiXo+R5rKKCj3yf8h/FAn7t34sXzT28x3eRUTRUY/X/AMm8k2uP9J1P+7F81Laynd5HmsZpaUHF2H/6byRr90/8SH5p7Sbh5FHw1H0z/ubySx9U78WL5piWTh5FRNNTbn/8hyT6fdn8SL5p7WXo+X3SNNS7n+Y5JuPq3fiRd5SEr+Cxup6fc/zCkDD6NP8AOP5o2z+gUfBwfuhRvJHmOPQWd5SD3n9KxPhp2/5l+5IO9h/azvJ3k6PmoalP0z/t+6V/2HdrO8mC/h5qJZDuefBNdKfVu7Wd5SueHmoFjL4O8immZ3qnnrj76Lnh5pajemPA8k02h3qZPej76NY9E+IT2bemPB3JIWl3qJO2Pvp6x4HyRsm9Mf8ALkl4y71MnbH30a3UffejZN6Y/wCXJDxp3qJf9vvo1+o+Seyb02+fJDxt3qZf9HfS1+op7AdNvnyQNrd6mX/R3ka/+kp7EdNvnyQNrPqpOxveS1+o++9GxF/zjz5JG1fdy9je8se0d0T5LOKaK/8A5R4FN8b9iT3R80tqeipClj/cHgVNeU1poVCME8U0lLBMJpCVgmhdRZMXKcOtMJFEDgnZK6cEjggAnIXSvdKLpWTgeCEsEaJpXSTSRqgoCFUJ2RxRilgnCqYBSwRUkkqdKEIgdKEkiUXRZNLuIUbqWrZAO4ouiydeTulZKqLoslX+UQhG8i6VkL6d07JX+P6oujVRvIulZAlO6dkCUigBCqSaGKE009KSaZXii6kiQoKV02iaV0qFJMC+Sa5qLpkEZoXUWRdODUItdFCVhxRuk4b0ipNtew34JNZ0p96ja5IspP5xRqXOJTEoaLNA7Tift69aA607KGskApKKckXAKTI3PyCicTsUbkqbmsAFjjvT2t4IWMutkU4kDNSwCjZxxRbJwTBQW23oknimVEWQ6vzSt1KVzldEAbkWCjikQP4UYJ4pwaE7BRJKBfQ0CEwLi6YXcVFSsj1o70kgeKaaLk1EIITSoiyLpBNCJei6Vk1x4JYKYBTSQjBMAppA3osEYqMu6UlOynohY7lAhI8FINJF00mqVgpF7kDRGCMeKAARglinAJ4KN0/kxtNFHWvksuzt+Y299XNK6OP6IxUfkvvPlzQkz+aTMsgssxsSLknt93tkiQshWsEQAsbrg5LKxrHA3cB3H7pDr/JA1ju80HZjInw+6TgdmW5LZ3xdmshqA35Y7gdeO7w8kY4TwUzZouVgYDI7Vak/cOs/JRFz2KbgxgtmeONu7LvuhTj+nyUrBY9c2tuRAUgoXRKaSVEk01F00gkhOBCd0lFIcf58klNoQH8y+SEFOH8y+SaScP5l8lLFJOFUYpYIHrSxQkUXQhX+YoummkoumEaJoumO6EkwmEIspqIx/wAqoWUtZf/Z"},{"source":"data:image/jpeg;base64,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"},{"source":"data:image/jpeg;base64,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"},{"source":"data:image/jpeg;base64,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"}]}');

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	// The module cache
/******/ 	var __webpack_module_cache__ = {};
/******/ 	
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/ 		// Check if module is in cache
/******/ 		var cachedModule = __webpack_module_cache__[moduleId];
/******/ 		if (cachedModule !== undefined) {
/******/ 			return cachedModule.exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = __webpack_module_cache__[moduleId] = {
/******/ 			id: moduleId,
/******/ 			// no module.loaded needed
/******/ 			exports: {}
/******/ 		};
/******/ 	
/******/ 		// Execute the module function
/******/ 		__webpack_modules__[moduleId](module, module.exports, __webpack_require__);
/******/ 	
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/ 	
/************************************************************************/
/******/ 	/* webpack/runtime/compat get default export */
/******/ 	(() => {
/******/ 		// getDefaultExport function for compatibility with non-harmony modules
/******/ 		__webpack_require__.n = (module) => {
/******/ 			var getter = module && module.__esModule ?
/******/ 				() => (module['default']) :
/******/ 				() => (module);
/******/ 			__webpack_require__.d(getter, { a: getter });
/******/ 			return getter;
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/define property getters */
/******/ 	(() => {
/******/ 		// define getter functions for harmony exports
/******/ 		__webpack_require__.d = (exports, definition) => {
/******/ 			for(var key in definition) {
/******/ 				if(__webpack_require__.o(definition, key) && !__webpack_require__.o(exports, key)) {
/******/ 					Object.defineProperty(exports, key, { enumerable: true, get: definition[key] });
/******/ 				}
/******/ 			}
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/hasOwnProperty shorthand */
/******/ 	(() => {
/******/ 		__webpack_require__.o = (obj, prop) => (Object.prototype.hasOwnProperty.call(obj, prop))
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/nonce */
/******/ 	(() => {
/******/ 		__webpack_require__.nc = undefined;
/******/ 	})();
/******/ 	
/************************************************************************/
var __webpack_exports__ = {};
// This entry need to be wrapped in an IIFE because it need to be in strict mode.
(() => {
"use strict";
/*!***********************************!*\
  !*** ./src/__extensions_index.ts ***!
  \***********************************/
__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _samples_grid_extender__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../samples/grid-extender */ "ext_mod_id_1728986549046_1");
/* harmony import */ var _samples_custom_fields__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../samples/custom-fields */ "ext_mod_id_1728986549046_2");
/* harmony import */ var _samples_commands_extender__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../samples/commands-extender */ "ext_mod_id_1728986549046_3");
/* harmony import */ var _samples_editor_extender__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../samples/editor-extender */ "ext_mod_id_1728986549046_4");
/* harmony import */ var _samples_item_extender__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../samples/item-extender */ "ext_mod_id_1728986549046_5");
/* harmony import */ var _samples_theme__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../samples/theme */ "ext_mod_id_1728986549046_6");
/* harmony import */ var _samples_fields_change__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../samples/fields-change */ "ext_mod_id_1728986549046_7");
/* harmony import */ var _samples_widget_editor__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../samples/widget-editor */ "ext_mod_id_1728986549046_8");
/* harmony import */ var _samples_tree_related_data__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ../samples/tree/related-data */ "ext_mod_id_1728986549046_9");
/* harmony import */ var _samples_custom_system_notifications_icons__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ../samples/custom-system-notifications-icons */ "ext_mod_id_1728986549046_10");
/* harmony import */ var _samples_library_extender__WEBPACK_IMPORTED_MODULE_10__ = __webpack_require__(/*! ../samples/library-extender */ "ext_mod_id_1728986549046_11");











sitefinityExtensionsStore.addExtensionModule(_samples_grid_extender__WEBPACK_IMPORTED_MODULE_0__.GridExtenderModule);
sitefinityExtensionsStore.addExtensionModule(_samples_custom_fields__WEBPACK_IMPORTED_MODULE_1__.CustomFieldsModule);
sitefinityExtensionsStore.addExtensionModule(_samples_commands_extender__WEBPACK_IMPORTED_MODULE_2__.CommandsExtenderModule);
sitefinityExtensionsStore.addExtensionModule(_samples_editor_extender__WEBPACK_IMPORTED_MODULE_3__.EditorExtenderModule);
sitefinityExtensionsStore.addExtensionModule(_samples_item_extender__WEBPACK_IMPORTED_MODULE_4__.ItemExtenderModule);
sitefinityExtensionsStore.addExtensionModule(_samples_theme__WEBPACK_IMPORTED_MODULE_5__.ThemeModule);
sitefinityExtensionsStore.addExtensionModule(_samples_fields_change__WEBPACK_IMPORTED_MODULE_6__.FieldsChangeModule);
sitefinityExtensionsStore.addExtensionModule(_samples_widget_editor__WEBPACK_IMPORTED_MODULE_7__.WidgetEditorExtenderModule);
sitefinityExtensionsStore.addExtensionModule(_samples_tree_related_data__WEBPACK_IMPORTED_MODULE_8__.RelatedDateExtenderModule);
sitefinityExtensionsStore.addExtensionModule(_samples_custom_system_notifications_icons__WEBPACK_IMPORTED_MODULE_9__.SystemNotificationsIconsExtenderModule);
sitefinityExtensionsStore.addExtensionModule(_samples_library_extender__WEBPACK_IMPORTED_MODULE_10__.LibraryExtenderModule);

})();

/******/ })()
;