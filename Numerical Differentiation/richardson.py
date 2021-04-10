#Numerical Differentiation using Richardson's Extrapolation

import math

#differentiation function
#d(x)= (f(x+h)-f(x-h))/2h
def differentiate(x,h):
    f1=f(x+h)
    f2=f(x-h)
    h2=2*h
    #print('f1 :',f1)
    #print('f2 :',f2)
    #print('2h :',h2)
    
    return ((f1-f2)/h2)

#f(x)=5x.e^(-2x)
def f(x):
    ans=((5*x)*(math.exp(-2*x)))
    #print('ans:',ans)
    return ans

def richard_ep(AV1,AV2):

    return (AV2+((AV2-AV1)/3))

def richardson(x):

    h=0.25              #step size
    h2=h/2              #calculating half step size

    #calculating approximation using step size h
    AV1=differentiate(x,h)
    
    #calculating approximation using step size h/2
    AV2=differentiate(x,h2)

    print('Approximation using h=',h,' is :',AV1)
    print('Approximation using h=',h2,' is :',AV2)

    #using richardson's extrapolation to find Actual Value
    TV=richard_ep(AV1,AV2)
    print('Actual Value using Richardson\'s Extrapolation: ',TV)
    

richardson(0.35)


'''
OUTPUT:
Approximation using h= 0.25  is : 0.988434518395231
Approximation using h= 0.125  is : 0.8047130405197818
Actual Value using Richardson's Extrapolation:  0.743472547894632

'''
