﻿using System;

namespace 外观模式
{
    class Program
    {
        //外观模式就是为了降低类与类之间的耦合度，各个类实现自己基础的功能，使用一个公共类来持有各个实例，
        //公共类实现各个功能，各个功能中再调用各自实例的基础方法【外观模式不涉及接口】
        //简单举例：
        //  CPU一个实体类 ；  硬盘一个实体类  ；  内存条一个实体类  ； 电脑开机的时候需要运行各个实体类， 那么 封装一个 电脑实体类 ； 
        //  在这个电脑类的公共类中实现各个功能， 各个功能再调用各自实例的基础方法
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
