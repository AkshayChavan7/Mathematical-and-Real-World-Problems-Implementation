#Monte-Carlo Simulation
import math
import numpy as np


def monte_carlo(spot,strike,rate,volatility,tenor):

    iterations=100  #Maximum number of iterations
    call=[]
    put=[]
    t=[]

    rand_nos=np.random.normal(0,1,iterations)

    for i in range(iterations):
        a=((rate*(volatility**2))/2)*tenor
        b=volatility*math.sqrt(tenor)*rand_nos[i]
        payoff=spot*math.exp(a+b)
        #print('payoff at',i,':',payoff)
        call.append(max(0,payoff-strike))
        put.append(max(0,strike-payoff))
        t.append(i)
    call_price=sum(call)/iterations
    put_price=sum(put)/iterations
    
   
    #After discounting
    print('Call Option Price:',call_price*math.exp((-rate)*tenor))
    print('Put Option Price:',put_price*math.exp((-rate)*tenor))
    

monte_carlo(100,120,0.05,0.3,1)
    

'''
OUTPUT:
Call Option Price: 6.3791440942515765
Put Option Price: 21.522960460016158
'''
