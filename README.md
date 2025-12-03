# Diga.WebView.AOT
AOT Version of [Diga.WebView2](https://github.com/ITAgnesmeyer/Diga.WebView2)

We have decided to separate this project from Diga.WebView2. The reasons for this are as follows:

1. **AOT Compilation**: Windows.Forms currently does not officially support Ahead-of-Time (AOT) compilation. It is unclear if or when this support will be implemented.

2. **Support by Other Frameworks**: Other projects, such as Avalonia, already support AOT compilation.

3. **Compatibility**: AOT compilation follows its own rules and is not backward compatible, which complicates integration into existing systems.

4. **Challenging Scope**: Achieving full coverage of the Diga.WebView2 project requires significant and challenging effort, making it a resource-intensive endeavor.

We plan to integrate as much of Diga.WebView2 into this project as possible. However, whether we will achieve complete coverage remains uncertain at this time.

