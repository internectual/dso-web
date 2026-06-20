// Test file for all 8 targets
// Exercises: functions, variables, arithmetic, strings, control flow

function testBasic()
{
   %a = 1;
   %b = 2;
   %c = %a + %b;
   return %c;
}

function testStrings()
{
   %s1 = "hello";
   %s2 = "world";
   %s3 = %s1 @ " " @ %s2;
   return %s3;
}

function testControlFlow()
{
   %x = 5;
   if (%x > 3)
   {
      return 1;
   }
   else
   {
      return 0;
   }
}

function testLoops()
{
   %sum = 0;
   for (%i = 0; %i < 10; %i++)
   {
      %sum = %sum + %i;
   }
   return %sum;
}

function testSwitch()
{
   %val = 2;
   switch (%val)
   {
      case 1:
         return "one";
      case 2:
         return "two";
      case 3:
         return "three";
   }
   return "default";
}

function testBitwise()
{
   %a = 0x0F;
   %b = 0xF0;
   return %a | %b;
}

function testComparison()
{
   %x = 5;
   %y = 10;
   if (%x < %y && %y > 0)
   {
      return true;
   }
   return false;
}

function testTernary()
{
   %x = 5;
   return (%x > 3) ? "big" : "small";
}

$globalVar = 42;

function testGlobal()
{
   return $globalVar;
}

function testFloat()
{
   %pi = 3.14159;
   %r = 2.0;
   return %pi * %r * %r;
}

function testModulo()
{
   return 17 % 5;
}

function testShift()
{
   return 1 << 8;
}

function testNot()
{
   %x = 0;
   if (!%x)
   {
      return 1;
   }
   return 0;
}

function testBreakContinue()
{
   %sum = 0;
   for (%i = 0; %i < 100; %i++)
   {
      if (%i == 50)
         break;
      if (%i % 2 == 0)
         continue;
      %sum = %sum + %i;
   }
   return %sum;
}

function testNestedIf()
{
   %x = 5;
   %y = 10;
   if (%x > 0)
   {
      if (%y > 0)
      {
         return %x + %y;
      }
   }
   return 0;
}

function testStringCompare()
{
   %a = "hello";
   %b = "world";
   if (%a $= %b)
   {
      return "same";
   }
   return "different";
}

function testUnary()
{
   %x = 5;
   %y = -%x;
   %z = ~%x;
   return %y + %z;
}

function testLogical()
{
   %a = 1;
   %b = 0;
   if (%a && %b)
   {
      return "both";
   }
   if (%a || %b)
   {
      return "either";
   }
   return "neither";
}
