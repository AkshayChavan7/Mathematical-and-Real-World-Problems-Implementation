#Backward Differentiation
import math


#f(x)=5x.e^(-2x)
def f(x):
    ans=((5*x)*(math.exp(-2*x)))
    #print('ans:',ans)
    return ans


def backward(x,h):
    return (f(x)-f(x-h))/h



print(backward(0.35,0.25))
