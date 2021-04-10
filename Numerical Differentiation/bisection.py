'''
Bisection Differentiation Method

Reference Link: https://x-engineer.org/undergraduate-engineering/advanced-mathematics/numerical-methods/the-bisection-method-for-root-finding/
'''

import matplotlib.pyplot as plt
import numpy

NMAX=1000       #maximum number of iterations allowed

#f(x)=10-x^2
def f(x):
    return (10-x**2)


#the values of a & b should have opposite signs
def bisection(a,b,tol):
    cnt=0
    x_list=[]
    fx_list=[]

    
    
    
    c=(a+b)/2
    fa=f(a)
    fb=f(b)
    fc=f(c)


    while cnt<=NMAX:    #do until max iterations
        
        fa=f(a)
        fb=f(b)
        fc=f(c)
        
        print('a:%.4f'%a,'\tb:%.4f'%b,'\tc:%.4f'%c,'\tfa:%.4f'%fa,'\tfb:%.4f'%fb,'\tfc:%.4f'%fc)

        if fc>=0 and fc<tol:        #if point is between 0 and tolerance level
            break
        
        if fc>0 and fa>0:
            a=c
        else:
            b=c
        c=(a+b)/2
        
        cnt+=1

    #visualization
    for i in numpy.arange(0,cnt,0.1):
        x_list.append(i)
        fx_list.append(f(i))

    plt.plot(x_list,fx_list)
    plt.scatter(c,fc,color='red')
    plt.xlabel('X')
    plt.ylabel('f(X)=10-X^2')
    plt.show()
            
    return c
    


print('Root value is: ',bisection(-2,5,0.01))
        

'''
OUTPUT:

a:-2.0000 	b:5.0000 	c:1.5000 	fa:6.0000 	fb:-15.0000 	fc:7.7500
a:-2.0000 	b:5.0000 	c:1.5000 	fa:6.0000 	fb:-15.0000 	fc:7.7500
a:1.5000 	b:5.0000 	c:3.2500 	fa:7.7500 	fb:-15.0000 	fc:-0.5625
a:1.5000 	b:3.2500 	c:2.3750 	fa:7.7500 	fb:-0.5625 	fc:4.3594
a:2.3750 	b:3.2500 	c:2.8125 	fa:4.3594 	fb:-0.5625 	fc:2.0898
a:2.8125 	b:3.2500 	c:3.0312 	fa:2.0898 	fb:-0.5625 	fc:0.8115
a:3.0312 	b:3.2500 	c:3.1406 	fa:0.8115 	fb:-0.5625 	fc:0.1365
a:3.1406 	b:3.2500 	c:3.1953 	fa:0.1365 	fb:-0.5625 	fc:-0.2100
a:3.1406 	b:3.1953 	c:3.1680 	fa:0.1365 	fb:-0.2100 	fc:-0.0360
a:3.1406 	b:3.1680 	c:3.1543 	fa:0.1365 	fb:-0.0360 	fc:0.0504
a:3.1543 	b:3.1680 	c:3.1611 	fa:0.0504 	fb:-0.0360 	fc:0.0072
Root value is:  3.1611328125
'''
