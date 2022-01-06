**单一职责原则（Single Responsibility Principle）**`，就一个类而言，应该仅有一个引起它变化的原因。`

如果一个类承担的职责过多，就等于把这些职责耦合在一起，一个职责的变化可能会削弱或者抑制这个类完成其他职责的能力。这种耦合会导致脆弱的设计，当变化发生时，设计会遭受到意想不到的破坏。

软件设计真正要做的许多内容，就是发现职责并把那些职责相互分离。其实要去判断是否应该分分离出来，也不难，那就是如果你能够想到多于一个的动机去改变一个类，那么这个类就具有多于一个的职责。



**开放-封闭原则（Open-Closed Principle）**，是说软件实体（类、模块、函数等等）应该可以扩展，但是不可修改。

> 这个原则有两个特征，一个是 “对于扩展是开放的（Open for extension）”，另一个是 “对于更改是封闭的（Closed for modification）”。

怎样的设计才能面对需求的改变却可以保持相对稳定，从而使得系统可以在第一个版本以后不断推出新的版本呢？开放-封闭给我们答案。

无论模块是多么的‘封闭’，都会存在一些无法对之封闭的变化。既然不可能完全封闭，设计人员必须对于他设计的模块应该对哪种变化封闭做出选择。他必须先猜测出最有可能发生的变化种类，然后构造抽象来隔离那些变化。

开放-封闭原则是面向对象设计的核心所在。遵循这个原则可以带来面向对象技术所声称的巨大好处，也就是可维护、可扩展、可复用、灵活性好。开发人员应该仅对程序中呈现出频繁变化的那些部分做出抽象，然而，对于应用程序中的每个部分都刻意地进行抽象同样不是一个好主意。拒绝不成熟的抽象和抽象本身一样重要。



**依赖倒转原则（Dependence Inversion Principle）**

> A. 高层模块不应该依赖底层模块。两个都应该依赖抽象。
>
> B.抽象不应该依赖细节。细节应该依赖抽象。

说白了，就是要针对接口编程，不要对实现编程。

依赖倒转其实可以说是面向对象设计的标志，用哪种语言来编写程序不重要，如果编写时考虑的都是如何针对抽象编程而不是针对细节编程，即程序中所有的依赖关系都是终止于抽象类或者接口，那就是面向对象的设计，反之那就是过程化的设计了。



**里氏代换原则（Liskov Substitution Principle）**`：子类型必须能够替换掉它们的父类型。`

一个软件实体如果使用的是一个父类的话，那么一定适用于其子类，而且它察觉不出父类对象和子类对象的区别。也就是说，在软件里面，把父类都替换成它的子类，程序的行为没有变化。

只有当子类可以替换掉父类，软件单位的功能不受影响时，父类才能真正被复用，而子类也能够在父类的基础上增加新的行为。

正是由于子类型的可替换性才使得使用父类类型的模块在无需修改的情况下就可以扩展。



**迪米特法则（Law Of Demeter）**`，如果两个类不必彼此直接通信，那么这两个类就不应当发生直接的相互作用。如果其中一个类需要调用另一个类的某一个方法的话，可以通过第三者转发这个调用。`

迪米特法则又称为最少知道原则，首先强调的前提是在类的结构设计上，每一个类都应当尽量降低成员的访问权限，也就是说，一个类包装好自己的private状态，不需要让别的类知道的字段或行为就不要公开。

其根本思想，是强调了类之间的松耦合。类之间的耦合越弱，越有利于复用，一个处在弱耦合的类被修改，不会对有关系的类造成波及。



**接口隔离原则 (Interface Segregation Principle)**

接口隔离原则，其 "隔离" 并不是准备的翻译，真正的意图是 “分离” 接口(的功能)。

接口隔离原则强调：客户端不应该依赖它不需要的接口；一个类对另一个类的依赖应该建立在最小的接口上。

> 1. 接口隔离原则的思想在于建立单一接口，尽可能地去细化接口，接口中的方法尽可能少
> 2. 但是凡事都要有个度，如果接口设计过小，则会造成接口数量过多，使设计复杂化。所以一定要适度



**组合/聚合复用原则 (Composite/Aggregate Reuse Principle)**`，在一个新的对象里面使用一些已有的对象，使之成为新对象的一部分; 新的对象通过向这些对象的委派达到复用已有功能的目的。`

> 1. 总体说来，组合/聚合复用原则告诉我们：组合或者聚合好过于继承。
> 2. 聚合组合是一种 “黑箱” 复用，因为细节对象的内容对客户端来说是不可见的。
