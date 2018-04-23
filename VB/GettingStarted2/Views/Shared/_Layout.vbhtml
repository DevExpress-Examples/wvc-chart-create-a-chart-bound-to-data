<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8" />
    <title>@ViewData("Title")</title>

                @Html.DevExpress().GetStyleSheets(
            New StyleSheet With {.ExtensionSuite = ExtensionSuite.Chart }
        )
        @Html.DevExpress().GetScripts(
            New Script With {.ExtensionSuite = ExtensionSuite.Chart }
        )
    
</head>

<body>
    @RenderBody()
</body>
</html>