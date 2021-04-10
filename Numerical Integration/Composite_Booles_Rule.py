'''
ASSIGNMENT NO-01
TITLE: Write programs to implement 4 Numerical Integration Methods, 4 Numerical Differentiation Methods and 4 Methods for
Random Number Generation. From a GUI, select a method for Random Number Generation. Generate random numbers
using C/C++, put in a table using SQL and show table using C#.

'''


#Numerical Integration using Composite Boole's Rule
import matplotlib.pyplot as plt
import math


def func(x):
    return x*(math.sin(x))
    
    
def Booles(a, b, n):
    h=(b-a)/n;          #here n=4 as per our case 
    
    
    x=[]
    fx=[]
    for i in range(0,n+1):
        temp_x=a+(i*h)
        x.append(temp_x)            #creating list of the values of x
        fx.append(func(x[i]))       #creating list of the values of fx
    
    print('Xi List: ', x)
    print('f(x) List: ',fx)
    
    #solving limit
    t1=(2*h)/45     #term1 
    z=n//4+1
    t2=0
    #calculating term2
    for j in range(1,z):
        #print(j)
        t2+=( (7*func(x[0])) + (32*func(x[1])) + (12*func(x[2])) + (32*func(x[3])) + (7*func(x[4])) )
    
    I=t1*t2                     #Integration result=term1*term2 
    
    print('Integration Result: ',I)

    plt.plot(x,y,label='Integration using composite Boole\'s Rule')
    plt.xlabel('X')
    plt.ylabel('f(X)')
        
        
#execute function
Booles(0,1.57,4)


'''
OUTPUT:

Xi List:  [0.0, 0.3925, 0.785, 1.1775, 1.57]                                                                                                                                         
f(x) List:  [0.0, 0.1501310526808338, 0.5548577671677123, 1.0875988310673694, 1.5699995022029805]                                                                                    
Integration Result:  0.99879293580178   


'''
