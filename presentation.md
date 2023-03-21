---
theme : "white"
transition: "slide"
highlightTheme: "vs2015"
slideNumber: true
logoImg: "https://github.com/Barsonax/nukepresentation/raw/master/images/nukeIcon.png"
title: "Stop creating tech debt! Start injecting your dependencies."
enableTitleFooter: false
---

## Stop creating tech debt! Start injecting your dependencies.

<a>
    <img style="border: unset; box-shadow: unset" data-src="https://github.com/Barsonax/nukepresentation/raw/master/images/nukeIcon.png">
</a>

---

## In this presentation

<p class="fragment">Why pay attention?</p>
<p class="fragment">What is it?</p>
<p class="fragment">Frameworks</p>
<p class="fragment">Implementation</p>

---

Why pay attention if I can develop software without it?
<p class="fragment">Software can be developed without:</p>

<p class="fragment">*    Clean code practices</p>
<p class="fragment">*    Testing</p>
<p class="fragment">*    CI/CD</p>
<p class="fragment">*    Code reviews</p>

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
    <img style="border: unset; box-shadow: unset" data-src="https://github.com/Barsonax/DependencyInjectionPresentation/raw/master/images/Build_for_the_long_term.png">
</a>

---

## Wat is Dependency Injection?

A simple idea

Obfuscated by the focus on bells and whistles (eg. frameworks, scoping etc.)

<p class="fragment">
> "25 dollar term for 25ct concept"
</p>

<p class="fragment">
```
Constructor()
{
    Processor = new Processor();
    Logger = new Logger();
}
```

</p>

<p class="fragment">vs.</p>
<p class="fragment">

```
Constructor(processor, logger)
{
    Processor = processor;
    Logger = logger;
}
```
</p>


