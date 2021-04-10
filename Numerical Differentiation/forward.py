#Forward Differentiation
import math


#f(x)=5x.e^(-2x)
def f(x):
    ans=((5*x)*(math.exp(-2*x)))
    #print('ans:',ans)
    return ans


def forward(x,h):
    return (f(x+h)-f(x))/h



print(forward(0.35,0.25))
