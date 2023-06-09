---
theme : "solarized"
transition: "slide"
highlightTheme: "vs2015"
slideNumber: true
logoImg: "https://raw.githubusercontent.com/Barsonax/DependencyInjectionPresentation/main/images/Uptrends_ITRS_logo_Injection.png"
title: "Stop creating tech debt! Start injecting your dependencies."
enableTitleFooter: false
---

## Stop creating tech debt! Start injecting your dependencies.

<a>
    <img style="border: unset; box-shadow: unset" data-src="https://raw.githubusercontent.com/Barsonax/DependencyInjectionPresentation/main/images/Uptrends_ITRS_logo_Injection.png">
</a>

---

## In this presentation

<ul>
    <li class="fragment">Why pay attention?</li>
    <li class="fragment">What is it?</li>
    <li class="fragment">Looking at code</li>
    <li class="fragment">Questions</li>
</ul>
---

Why pay attention if I can develop software without it?
<p class="fragment">Software can be developed without:</p>

<ul>
    <li class="fragment">Clean code practices</li>
    <li class="fragment">Testing</li>
    <li class="fragment">CI/CD</li>
    <li class="fragment">Code reviews</li>
</ul>

--

### Cost of not injecting dependencies

<p class="fragment">Refactorings</p>
<p class="fragment">Complexity</p>
<p class="fragment">Scope creep</p>
<p class="fragment">Testability</p>
<p class="fragment">Speed</p>

--

## Company value

Build for the long-term

<a>
    <img style="border: unset; box-shadow: unset" data-src="https://raw.githubusercontent.com/Barsonax/DependencyInjectionPresentation/main/images/Build_for_the_long_term.png">
</a>

---

## What is Dependency Injection?

<p class="fragment">A simple idea</p>

<p class="fragment">Obfuscated by the focus on bells and whistles (eg. frameworks, scoping etc.)</p>

<div class="fragment" cite="https://stackoverflow.com/a/140655/2675101">
<q>25 dollar term for 5ct concept</q>
<br/>
-James Shore
</div>

---

### Regular code

```csharp
Constructor()
{
    Processor = new Processor();
    Logger = new Logger();
}
```

---

### Dependency injection

```csharp
Constructor(processor, logger)
{
    Processor = processor;
    Logger = logger;
}
```

---

<span class="fragment">Making the creation of objects </span> <span class="fragment">on which a class depends</span> <span class="fragment">someone else's problem.</span> <span class="fragment">Another way to say it is </span><span class="fragment">that DI makes classes more cohesive</span> <span class="fragment">(they have fewer responsibilities).</span>

---

## Let's look at some code!

---

## Questions?

---

## Resources

- https://stackoverflow.com/questions/130794/what-is-dependency-injection
- Recommended for the basic simple concept https://www.jamesshore.com/v2/blog/2006/dependency-injection-demystified
- For relevant PRs in our codebase, check out the Readme.md in the example project
