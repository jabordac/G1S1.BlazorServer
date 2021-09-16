// From C# to JS
function DisplayMessageCSToJS(messageText) {
    return confirm(messageText);
}

// From JS to C#
function DisplayMessageJSToCS(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("DisplayMessage");
}