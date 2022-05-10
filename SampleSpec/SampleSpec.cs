using System;
using Machine.Specifications;

namespace SampleSpec
{
    public class when_increasing_int 
    {
//      Establish context = () => {  sut = 1; };

//      Because of = () => { sut = sut + 1; };

        private It should_be_equal_to_two = () =>
        {
                    (1 + 1).ShouldEqual(2);

        };
//      It should_be_equal_to_two1 = () => { };

        private static int sut;
    }
}